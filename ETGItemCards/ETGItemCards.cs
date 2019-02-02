using System.IO;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using static ETGModConsole;
using System;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Xml.Serialization;
using MonoMod.RuntimeDetour;

namespace ETGItemCards
{
    /// <summary>
    /// Initializes ETGItemCards
    /// </summary>
    public class ETGItemCards : ETGModule
    {
        public override void Init() { }

        /// <summary>
        /// Load ETGItemCards hooks initialize classes
        /// </summary>
        public override void Start()
        {
            //Command to load the debug functions used for development.
            //Debug function are undocumented, use at your own risk
            Commands.AddGroup("loadDebugFunctions", DebugFunctions.LoadDebugFunctions);

            //Create a hook for the GameUIRoot class for running this mods update loop
            MethodBase gameUIUpdate = typeof(TimeInvariantMonoBehaviour).GetMethod("Update", (BindingFlags)(-1));
            MethodInfo gameUIUpdateHook = typeof(PickupTracker).GetMethod("UpdateHook", (BindingFlags)(-1));

            new Hook(gameUIUpdate, gameUIUpdateHook);

            //Track intantiation and deletion of the objects that are needed for tracking
            TypeTracker.TrackType(typeof(PickupObject));
            TypeTracker.TrackType(typeof(ShopItemController));
            TypeTracker.TrackType(typeof(RewardPedestal));

            //Log that the mod loaded, for players
            Log("Item Cards Loaded");
        }

        public override void Exit() { }
    }
}