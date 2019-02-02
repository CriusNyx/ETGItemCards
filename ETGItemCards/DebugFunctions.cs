using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static ETGModConsole;
using UnityEngine;
using System.Text;
using System.Xml.Serialization;

namespace ETGItemCards
{
    /// <summary>
    /// These functions were used for the devlopment of this mod
    /// They currently have no use in the mod
    /// Use at your own risk
    /// </summary>
    public static class DebugFunctions
    {
        public static void LoadDebugFunctions(string[] args)
        {
            Commands.AddGroup("hinit", HInit);
            Commands.AddGroup("hdiff", HDiff);
            Commands.AddGroup("listPickups", ListPickups);
            Commands.AddGroup("listCameras", ListCameras);
            Commands.AddGroup("exit", (x) => Application.Quit());
            Commands.AddGroup("printByName", PrintByName);
            Commands.AddGroup("printLabels", PrintLabels);
            Commands.AddGroup("listOutlines", ListOutlines);
        }

        public static SortedList<string, List<GameObject>> oldList;
    
        public static string[] ResolveArgs(string[] args)
        {
            if(args == null)
            {
                return new string[] { };
            }

            List<string> output = new List<string>();
            string temp = "";
            bool quotes = false;
            foreach(var arg in args)
            {
                if(arg.Length == 0)
                    continue;
                if(quotes)
                {
                    if(arg.EndsWith("\""))
                    {
                        temp = temp + " " + arg.Substring(0, arg.Length - 1);
                        output.Add(temp);
                        temp = "";
                        quotes = false;
                    }
                    else
                    {
                        temp = temp + arg;
                    }
                }
                else if(arg.StartsWith("\""))
                {
                    temp = arg.Substring(1);
                    quotes = true;
                }
                else
                {
                    output.Add(arg);
                }
            }

            return output.ToArray();
        }

        public static void PrintLabels(string[] args)
        {
            string pattern = "";
            if(args != null)
            {
                pattern = string.Join(" ", args);
            }

            //Func<string, bool> match = (x) => { return true; };

            Regex regex = null;

            if(pattern != "")
            {
                regex = new Regex(pattern);
            }

            foreach(dfLabel label in UnityEngine.Object.FindObjectsOfType<dfLabel>())
            {
                if(!label.isActiveAndEnabled)
                    continue;
                if(regex != null)
                {
                    if(regex.IsMatch(label.name))
                        Log(label.name);
                }
                else
                {
                    Log(label.name);
                }
            }
        }

        public static void PrintByName(string[] names)
        {
            if(names == null)
            {
                Log("You must enter a name to use this command");
            }
            if(names.Length == 0)
            {
                Log("You must enter a name to use this command");
            }
            Log("Printing objects with name");

            names = ResolveArgs(names);
            foreach(var name in names)
            {
                Log(name);
            }
            foreach(GameObject gameObject in UnityEngine.Object.FindObjectsOfType<GameObject>())
            {
                foreach(var name in names)
                {
                    if(gameObject.name == name)
                    {
                        Log(GetObjectData(gameObject), true);
                        break;
                    }
                }
            }
        }

        public static void ListCameras(string[] args)
        {
            Log("Listing Cameras");
            Log("");

            bool active = false;
            if(args != null)
                foreach(var arg in args)
                {
                    if(arg == "active" || arg == "enabled")
                    {
                        active = true;
                    }
                }

            int count = 0;
            foreach(Camera camera in UnityEngine.Object.FindObjectsOfType<Camera>())
            {
                if(active)
                {
                    if(camera.enabled)
                    {
                        ListCam(camera);
                        count++;
                    }
                }
                else
                {
                    ListCam(camera);
                    count++;
                }
            }
            Log("Done: Camera Count: " + count);
        }

        public static void ListCam(Camera camera)
        {
            Log(camera.name);
            if(camera.name == "UI Camera")
            {
                foreach(Component comp in camera.GetComponents<Component>())
                {
                    Log("---" + comp.GetType().ToString());
                }
            }
        }

        public static void HInit(string[] args)
        {
            Log("Initializing Heigharchy");
            oldList = GetH();
            Log("Done");
        }

        public static void HDiff(string[] args)
        {
            if(oldList == null)
            {
                HInit(args);
                return;
            }
            Log("Initializing Diff");
            var newList = GetH();
            string output = CompareLists(oldList, newList);
            Log(output);
            oldList = newList;
            Log("Done");
        }

        public static string CompareLists(SortedList<string, List<GameObject>> oldList, SortedList<string, List<GameObject>> newList)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var n in newList)
            {
                foreach(GameObject go in n.Value)
                {
                    if(!oldList.ContainsKey(n.Key))
                    {
                        sb.AppendLine("Created: " + n.Key);
                        sb.AppendLine(GetObjectData(go));
                    }
                    else if(!oldList[n.Key].Contains(go))
                    {
                        sb.AppendLine("Created: " + n.Key);
                        sb.AppendLine(GetObjectData(go));
                    }
                }
            }
            foreach(var n in oldList)
            {
                foreach(GameObject go in n.Value)
                {
                    if(!newList.ContainsKey(n.Key))
                    {
                        sb.AppendLine("Deleted: " + n.Key);
                    }
                    else if(!newList[n.Key].Contains(go))
                    {
                        sb.AppendLine("Deleted: " + n.Key);
                    }
                }
            }

            return sb.ToString();
        }

        public static void ListPickups(string[] args)
        {
            foreach(var po in UnityEngine.Object.FindObjectsOfType<PickupObject>())
            {
                Log(GetObjectHeigharchy(po.gameObject) + "\n");
            }
        }

        public static string GetObjectHeigharchy(GameObject gameObject)
        {
            int indent;
            string temp = GetObjectParentHeigharchy(gameObject, out indent);
            return temp + Indent(GetObjectChildrenHeigharchy(gameObject), indent, "___");
        }

        /// <summary>
        /// Gets the parent heigharchy of the object, inclusive
        /// </summary>
        /// <param name="gameObject"></param>
        /// <param name="indent"></param>
        /// <returns></returns>
        public static string GetObjectParentHeigharchy(GameObject gameObject, out int indent)
        {
            string parentPart = "";
            indent = 0;
            if(gameObject.transform.parent != null)
            {
                parentPart = GetObjectParentHeigharchy(gameObject.transform.parent.gameObject, out indent);
            }
            string thisPart = Indent(GetComponents(gameObject, "*"), indent, "___");
            indent = indent + 1;
            return parentPart + thisPart;
        }

        /// <summary>
        /// Gets the child heigharchy of the object
        /// </summary>
        /// <param name="gameObject"></param>
        /// <returns></returns>
        public static string GetObjectChildrenHeigharchy(GameObject gameObject, bool inclusive = false)
        {
            StringBuilder sb = new StringBuilder();
            if(inclusive)
            {
                sb.AppendLine(GetComponents(gameObject, "*"));
            }
            foreach(Transform child in gameObject.transform)
            {
                sb.AppendLine(Indent(GetObjectChildrenHeigharchy(child.gameObject, true), 1, "___"));
            }
            return sb.ToString();
        }

        public static string GetComponents(GameObject gameObject, string indent)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(gameObject.name);

            foreach(var component in gameObject.GetComponents<Component>())
            {
                string enabled = "";
                if(component is Behaviour)
                {
                    if((component as Behaviour).enabled)
                    {
                        enabled = "[X] ";
                    }
                    else
                    {
                        enabled = "[ ] ";
                    }
                }
                output.AppendLine(indent + enabled + component.GetType().ToString());
                if(component is MeshRenderer)
                {
                    MeshRenderer renderer = component as MeshRenderer;
                    Material material = renderer.material;
                    Shader shader = material.shader;
                    output.AppendLine(indent + "____Color: " + renderer.material.color);
                    output.AppendLine(indent + "____Material: " + material.name);
                    output.AppendLine(indent + "____Shader: " + shader.name);
                    if(renderer.material.shader.name == "Brave/Internal/SinglePassOutline")
                    {
                        try
                        {
                            output.AppendLine(indent + "____ShaderData");
                            output.AppendLine(indent + "_____OverrideColor: " + material.GetVector("_OverrideColor").ToString());
                            output.AppendLine(indent + "_____Perpendicular: " + material.GetFloat("_Perpendicular").ToString());
                            output.AppendLine(indent + "_____LuminanceCutoff: " + material.GetFloat("_LuminanceCutoff").ToString());
                            output.AppendLine(indent + "_____AtlasData: " + material.GetVector("_AtlasData").ToString());
                            output.AppendLine(indent + "_____MaterialSourceIsSinglePassOutline: " + material.GetFloat("_MaterialSourceIsSinglePassOutline").ToString());
                            output.AppendLine(indent + "_____InteriorToggle: " + material.GetFloat("_InteriorToggle").ToString());
                        }
                        catch
                        {
                            output.AppendLine(indent + "_____Error");
                        }
                    }
                    output.AppendLine(indent + "____Enabled: " + renderer.enabled);
                }
                if(component is tk2dSprite)
                {
                    tk2dSprite sprite = component as tk2dSprite;
                    output.AppendLine(indent + "____Color: " + sprite.color);
                    output.AppendLine(indent + "____IsBraveOutlineSprite" + sprite.IsBraveOutlineSprite);
                    output.AppendLine(indent + "____IsOutlineSprite" + sprite.IsOutlineSprite);
                    if(sprite == null)
                    {
                        output.AppendLine(indent + "____SpriteName: Null");
                    }
                    else
                    {
                        output.AppendLine(indent + "____SpriteName: " + sprite.CurrentSprite.name);
                    }
                }
            }
            return output.ToString();
        }

        public static string Indent(string input, int amount = 1, string indentString = "\t")
        {
            string indent = "";

            for(int i = 0; i < amount; i++)
            {
                indent += indentString;
            }

            input = indent + input;
            input = input.Replace("\n", "\n" + indent);
            return input;
        }

        public static string GetObjectData(GameObject gameObject, bool recursive = false, int indent = 0)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(gameObject.name);
            foreach(Component component in gameObject.GetComponents<Component>())
            {
                for(int i = 0; i < indent; i++)
                {
                    sb.Append("---");
                }
                sb.AppendLine("---" + component.GetType().ToString());
            }
            if(recursive)
            {
                foreach(Transform child in gameObject.transform)
                {
                    sb.AppendLine(GetObjectData(child.gameObject, recursive, indent + 1));
                }
            }
            else if(gameObject.transform.parent != null)
            {
                for(int i = 0; i < indent; i++)
                {
                    sb.Append("---");
                }
                sb.AppendLine("Parent");
                for(int i = 0; i < indent; i++)
                {
                    sb.Append("---");
                }

                sb.AppendLine(GetObjectData(gameObject.transform.parent.gameObject));
            }

            return sb.ToString();
        }


        public static SortedList<string, List<GameObject>> GetH()
        {
            var output = new SortedList<string, List<GameObject>>();
            foreach(GameObject gameObject in UnityEngine.Object.FindObjectsOfType<GameObject>())
            {
                string path = GetPath(gameObject.transform);
                if(!output.ContainsKey(path))
                {
                    output.Add(path, new List<GameObject>());
                }
                output[path].Add(gameObject);
            }
            return output;
        }

        private static string GetPath(Transform transform)
        {
            if(transform == null)
            {
                return "";
            }
            else
            {
                return string.Format("{0}/{1}", GetPath(transform.parent), transform.name);
            }
        }

        public static void ListOutlines(string[] args)
        {
            foreach(GameObject gameObject in UnityEngine.Object.FindObjectsOfType<GameObject>())
            {
                if(gameObject.name == "BraveOutlineSprite")
                {
                    Log(GetObjectHeigharchy(gameObject));
                }
            }
        }
    }
}
