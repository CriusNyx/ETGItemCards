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

            //command to set desired format for item cards
            Commands.AddGroup("SetCardFormat", SetCardFormat);

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

        public static void SetCardFormat(string[] args)
        {
            ETGSettings.Save();
            if(args == null || args.Length < 1)
            {
                Log("You must enter a value");
            }
            switch(args[0])
            {
                case "lite":
                case "LITE":
                case "Lite":
                {

                    var card = new ItemCardFormat(ItemCardFormat.LITE);
                    ETGSettings.SetCurrentFormat(card);
                    break;
                }
                case "full":
                case "FULL":
                case "Full":
                {
                    var card = new ItemCardFormat(ItemCardFormat.FULL);
                    ETGSettings.SetCurrentFormat(card);
                    break;
                }
                default:
                    try
                    {
                        string text = File.ReadAllText("mods/ItemCardFormats/" + args[0]);
                        var format = new ItemCardFormat(text);
                        ETGSettings.SetCurrentFormat(format);
                    }
                    catch(System.IO.IOException e)
                    {
                        Log("Failed to load file \"" + args[0] + ".\"\n Format files should be installed in mods/ItemCardFormats");
                    }
                    catch(ItemCardFormat.ItemCardFormatException e)
                    {
                        Log("Invalid Format");
                    }
                    break;
            }
        }

        public override void Exit() { }
    }
}