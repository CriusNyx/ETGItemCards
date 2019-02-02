using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using static ETGModConsole;

namespace ETGItemCards
{
    /// <summary>
    /// Uses hooks to track all MonoBehaviour instances of any type registered with it
    /// Use TrackType to begin tracking an object
    /// Use GetTrackedObjects to get a list of currently tracked objects
    /// </summary>
    public class TypeTracker
    {
        /// <summary>
        /// Singleton implementation
        /// </summary>
        static TypeTracker instance;
        /// <summary>
        /// Singleton Instance
        /// </summary>
        static TypeTracker Instance
        {
            get
            {
                if(instance == null)
                    instance = new TypeTracker();
                return instance;
            }
        }

        /// <summary>
        /// A list of the types currently tracked
        /// </summary>
        List<Type> trackedTypes = new List<Type>();

        /// <summary>
        /// A list of objects of each type being tracked
        /// </summary>
        Dictionary<Type, List<object>> tracker = new Dictionary<Type, List<object>>();

        /// <summary>
        /// Hook to track object creation
        /// </summary>
        Dictionary<Type, List<Hook>> hooks = new Dictionary<Type, List<Hook>>();

        /// <summary>
        /// Begin tracking the specified type
        /// </summary>
        /// <param name="type"></param>
        public static void TrackType(Type type)
        {
            Instance._TrackType(type);
        }

        /// <summary>
        /// Begin tracking the specified type
        /// </summary>
        /// <param name="type"></param>
        private void _TrackType(Type type)
        {
            //Add the type to the tracking list
            trackedTypes.Add(type);
            tracker.Add(type, new List<object>());

            //Attempt to bind hook for Awake
            try
            {
                MethodInfo awake = type.GetMethod("Awake", (BindingFlags)(-1));
                MethodInfo awakeOrStartHook = typeof(TypeTracker).GetMethod("AwakeOrStartHook", (BindingFlags)(-1)).MakeGenericMethod(type);

                AddHook(type, hooks, awake, awakeOrStartHook);
            }
            catch
            {
                //Log("Failed to bind Awake on: " + type.ToString());
            }

            //Attempt to bind hook for Start
            try
            {
                MethodInfo start = type.GetMethod("Start", (BindingFlags)(-1));
                MethodInfo awakeOrStartHook = typeof(TypeTracker).GetMethod("AwakeOrStartHook", (BindingFlags)(-1)).MakeGenericMethod(type);

                AddHook(type, hooks, start, awakeOrStartHook);
            }
            catch
            {
                //Log("Failed to bind Start on: " + type.ToString());
            }

            //Attempt to bind hook for constructor
            try
            {
                MethodBase ctor = type.GetConstructor((BindingFlags)(-1), null, CallingConventions.Any, new Type[] { }, null);
                MethodInfo awakeOrStartHook = typeof(TypeTracker).GetMethod("AwakeOrStartHook", (BindingFlags)(-1)).MakeGenericMethod(type);

                AddHook(type, hooks, ctor, awakeOrStartHook);
            }
            catch
            {
                //Log("Failed to bind CTOR on: " + type.ToString());
            }

            //Attempt to bind hook for on destroy
            try
            {
                MethodInfo onDestroy = type.GetMethod("OnDestroy", (BindingFlags)(-1));
                MethodInfo onDestroyHook = typeof(TypeTracker).GetMethod("OnDestroyHook", (BindingFlags)(-1)).MakeGenericMethod(type);

                AddHook(type, hooks, onDestroy, onDestroyHook);
            }
            catch
            {
                //Log("Failed to bind OnDestroy on: " + type.ToString());
            }
        }

        /// <summary>
        /// Add a new hook to the dictinoary, managing the data in the dictionary
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dictionary"></param>
        /// <param name="method"></param>
        /// <param name="hook"></param>
        private void AddHook(Type type, Dictionary<Type, List<Hook>> dictionary, MethodBase method, MethodInfo hook)
        {
            if(!dictionary.ContainsKey(type))
            {
                dictionary.Add(type, new List<Hook>());
            }
            dictionary[type].Add(new Hook(method, hook));
        }

        /// <summary>
        /// Remove the hooks for the specified type
        /// If you are requred to call this, you may need to reconsider the logic for your mod
        /// Once you remove the hook, keeping track of object instances will become very challenging.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dictionary"></param>
        private void RemoveHook(Type type, Dictionary<Type, List<Hook>> dictionary)
        {
            if(!dictionary.ContainsKey(type))
            {
                return;
            }
            foreach(var hook in dictionary[type])
            {
                hook.Dispose();
            }
            dictionary.Remove(type);
        }

        /// <summary>
        /// Stop tracking the specified type
        /// If you are requred to call this, you may need to reconsider the logic for your mod
        /// Once you remove the hook, keeping track of object instances will become very challenging.
        /// </summary>
        /// <param name="type"></param>
        private static void StopTrackingtype(Type type)
        {
            Instance._StopTrackingType(type);
        }

        /// <summary>
        /// Remove the type and it's hooks from the memory
        /// </summary>
        /// <param name="type"></param>
        private void _StopTrackingType(Type type)
        {
            trackedTypes.Remove(type);
            tracker.Remove(type);
            RemoveHook(type, hooks);
        }

        /// <summary>
        /// Hook to add an object to the dictinoary for tracking
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="orig"></param>
        /// <param name="o"></param>
        private static void AwakeOrStartHook<T>(Action<T> orig, T o)
        {
            Instance._AwakeOrStartHook(orig, o);
        }

        /// <summary>
        /// Add the object to the dictionary for tracking
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="orig"></param>
        /// <param name="o"></param>
        private void _AwakeOrStartHook<T>(Action<T> orig, T o)
        {
            //Log("Created: " + o.ToString());

            orig(o);

            if(!tracker[typeof(T)].Contains(o))
                tracker[typeof(T)].Add(o);
        }

        /// <summary>
        /// Hook to remove an object from the dictinoary for tracking
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="orig"></param>
        /// <param name="o"></param>
        private static void OnDestroyHook<T>(Action<T> orig, T o)
        {
            orig(o);

            Instance._OnDestroyHook<T>(orig, o);
        }

        /// <summary>
        /// Remove the object from tracking
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="orig"></param>
        /// <param name="o"></param>
        private void _OnDestroyHook<T>(Action<T> orig, T o)
        {
            orig(o);

            //Log("Destroyed: " + o.ToString());

            _Remove<T>(o);
        }

        /// <summary>
        /// Get a list of tracked objects of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetTrackedObjects<T>() where T : class
        {
            return Instance._GetTrackedObjects<T>();
        }

        /// <summary>
        /// Get a list of tracked objects of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private IEnumerable<T> _GetTrackedObjects<T>() where T : class
        {
            if(!tracker.ContainsKey(typeof(T)))
            {
                return new T[] { };
            }
            else
            {
                List<T> output = new List<T>();
                foreach(var o in tracker[typeof(T)])
                {
                    output.Add((T)o);
                }
                return output;
            }
        }

        /// <summary>
        /// Remove an object from the dictionary that failed to be cleaned up properly
        /// Ideally this method wouldn't exist, but null checks on generic types do not work as expected, so the logic must be executed outside of this class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        public static void Remove<T>(T o)
        {
            Instance._Remove<T>(o);
        }

        /// <summary>
        /// Remove an object from the dictionary that failed to be cleaned up properly
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        private void _Remove<T>(T o)
        {
            try
            {
                tracker[typeof(T)].Remove(o);
            }
            catch
            {
                //Log("Failed to remove tracked object: " + typeof(T).ToString());
            }
        }
    }
}