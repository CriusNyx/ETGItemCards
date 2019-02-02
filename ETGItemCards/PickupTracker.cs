using SGUI;
using UnityEngine;
using static ETGModConsole;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;

namespace ETGItemCards
{
    /// <summary>
    /// This class is responcible for tracking the active items on screen, and displaying item cards for them
    /// </summary>
    public class PickupTracker
    {
        /// <summary>
        /// The label to display item cards on
        /// </summary>
        static dfLabel label;

        /// <summary>
        /// Update hook for item tracking
        /// Hooked onto TimeInvariantMonoBehaviour.Update, but targeted at GameUIRoot
        /// </summary>
        /// <param name="orig"></param>
        /// <param name="timeBehaviour"></param>
        public static void UpdateHook(Action<TimeInvariantMonoBehaviour> orig, TimeInvariantMonoBehaviour timeBehaviour)
        {
            //call the original method on TimeInvariantMonoBehaviour
            orig(timeBehaviour);

            //Check if this is the GameUIRoot
            if(timeBehaviour is GameUIRoot)
            {
                //Run update loop
                GameUIRoot uiRoot = timeBehaviour as GameUIRoot;

                //Dynamically initialize the label, if it's null
                if(label == null)
                {
                    //get the label used to list the number of keys the player has
                    dfLabel keyLabel = uiRoot.p_playerKeyLabel;
                    if(keyLabel != null)
                    {
                        //create a new label, to display under key label
                        GameObject newLabelGO = new GameObject("Label");
                        newLabelGO.transform.parent = keyLabel.transform;
                        label = newLabelGO.AddComponent<dfLabel>();

                        //initialize the new label with the data needed.
                        label.Font = keyLabel.Font;
                        label.Position = keyLabel.Position + Vector3.down * 100;
                        label.AutoSize = true;
                        label.Text = "An error has occured. Plase contact the ItemCard mod developer";
                        label.IsVisible = true;
                        //Disable is localized to disable text translating
                        label.IsLocalized = false;
                        label.ProcessMarkup = true;
                        label.TextScale = (int)(keyLabel.TextScale * 2f / 3f);
                    }
                }

                //test case if the label is null
                if(label == null)
                {
                    return;
                }

                //update the label to display item cards
                try
                {
                    PlayerController player = Gungeon.Game.PrimaryPlayer;
                    bool draw = false;
                    if(player != null)
                    {
                        if(!player.IsInCombat)
                        {
                            draw = true;
                        }
                    }

                    if(draw)
                    {
                        label.Text = GetItemCard();
                    }
                    else
                    {
                        label.Text = "";
                    }
                }
                catch(System.Exception e)
                {
                    //catch and display errors
                    label.Text = e.ToString() + "\nAn error has occured. Plase contact the ItemCard mod developer"; ;
                }
            }
        }

        /// <summary>
        /// The the item card for the item currently looked at by the player character
        /// </summary>
        /// <returns></returns>
        private static string GetItemCard()
        {
            //Display title
            string text = "Item Card\n";

            //Flag to toggle display
            bool display = false;

            //itterate through the pickups
            foreach(var pickup in GetPickups())
            {
                //determine if this pickup is highlighted
                if(IsOutlined(pickup.gameObject))
                {
                    //get pickup text
                    text += GetPickupText(pickup);

                    //mark display flag
                    display = true;
                }
            }

            //itterate through shop items
            foreach(var item in GetShopItems())
            {
                //dertemine if this pickup is highlighted
                if(IsOutlined(item.gameObject))
                {
                    //get pickup text
                    text += GetPickupText(item.item);

                    //mark display flag
                    display = true;
                }
            }

            //itterate through pedestal items
            foreach(var ped in GetPedestalItems())
            {
                //determine if this pickup is highlighted
                if(IsOutlined(ped.gameObject))
                {
                    //extra null check for error detection
                    if(ped.contents != null)
                    {
                        //get pickup text
                        text += GetPickupText(ped.contents);

                        //mark display flag
                        display = true;
                    }
                    else
                    {
                        text += "Null\n";
                    }
                }
            }

            //Return appropriate output
            if(!display)
            {
                return "";
            }
            else
            {
                return text;
            }
        }

        /// <summary>
        /// Get the text for the specified pickup
        /// </summary>
        /// <param name="pickup"></param>
        /// <returns></returns>
        private static string GetPickupText(PickupObject pickup)
        {
            if(pickup == null)
            {
                return "";
            }

            int id = pickup.PickupObjectId;

            //add title text
            string output = string.Format("{0}: {1}", pickup.DisplayName, id);

            //Get item data from item card
            if(ItemData.Items.ContainsKey(id))
            {
                output += ItemData.Items[id].text;
                return output;
            }
            else
            {
                return output;
            }
        }

        /// <summary>
        /// Get a list of all pickups that are on the ground
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<PickupObject> GetPickups()
        {
            List<PickupObject> output = new List<PickupObject>();

            //itterate through all loaded pickups
            foreach(var pickup in TypeTracker.GetTrackedObjects<PickupObject>())
            {
                //this check is used to help keep TypeTracker clean
                //this helps prevent leaks
                //Ideally this code would be in TypeTracker instead, but for some reason, the null check works unexpectidly on generics
                if(pickup == null)
                {
                    TypeTracker.Remove<PickupObject>(pickup);
                }
                else
                {
                    //determine if this pickup is a debris object
                    bool debris = pickup.GetComponentInParent<DebrisObject>() != null || pickup.GetComponentInChildren<DebrisObject>() != null;
                    if(debris)
                        output.Add(pickup);
                }
            }

            return output;
        }

        /// <summary>
        /// Get a list of all items in the shop
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<ShopItemController> GetShopItems()
        {
            List<ShopItemController> output = new List<ShopItemController>();

            //itterate through all loaded shop items
            foreach(var shopItem in TypeTracker.GetTrackedObjects<ShopItemController>())
            {
                //this check is used to help keep TypeTracker clean
                //this helps prevent leaks
                //Ideally this code would be in TypeTracker instead, but for some reason, the null check works unexpectidly on generics
                if(shopItem == null)
                {
                    TypeTracker.Remove<ShopItemController>(shopItem);
                }
                else
                {
                    output.Add(shopItem);
                }
            }

            return output;
        }

        /// <summary>
        /// Gets a list of all items currently on a pedestal
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<RewardPedestal> GetPedestalItems()
        {
            List<RewardPedestal> output = new List<RewardPedestal>();

            //itterate through all pedestal items
            foreach(var ped in TypeTracker.GetTrackedObjects<RewardPedestal>())
            {

                //this check is used to help keep TypeTracker clean
                //this helps prevent leaks
                //Ideally this code would be in TypeTracker instead, but for some reason, the null check works unexpectidly on generics
                if(ped == null)
                {
                    TypeTracker.Remove<RewardPedestal>(ped);
                }
                else
                {
                    output.Add(ped);
                }
            }
            return output;
        }

        /// <summary>
        /// Determine if an object is currently outlined
        /// In most cases, the only highlighted item will be the item the player is looking at, or items in the players inventory.
        /// </summary>
        /// <param name="gameObject"></param>
        /// <returns></returns>
        private static bool IsOutlined(GameObject gameObject)
        {
            try
            {
                //Check if this object is a BraveOutlineSprite
                if(gameObject.name == "BraveOutlineSprite")
                {
                    //If this object is, check it's material for it's _OverrideColor property
                    MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
                    Vector4 vector = renderer.material.GetVector("_OverrideColor");
                    return vector == Vector4.one;
                }
                else
                {
                    //If this object is not a BraveOutlineSprite, itterate over this items children
                    foreach(Transform child in gameObject.transform)
                    {
                        //If any child is outlined, short circuit and return
                        if(IsOutlined(child.gameObject))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}