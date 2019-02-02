using SGUI;
using UnityEngine;
using static ETGModConsole;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

public class PickupTracker : MonoBehaviour
{
    dfLabel label;

    public static PickupTracker Create(GameObject gameObject, dfLabel label)
    {
        var output = gameObject.AddComponent<PickupTracker>();
        output.label = label;

        Log("Pickup Tracker Created");
        return output;
    }

    public void Start()
    {
        Log("Pickup Tracker Start");
    }

    public void Update()
    {
        if(label == null)
        {
            Log("label is null");
            Destroy(this);
            return;
        }

        //try to change font size
        try
        {
            if(label.Font.FontSize != 18)
                label.Font.FontSize = 18;
        }
        catch { }
        string text = "Item Card\n";

        int id = -1;
        foreach(var pickup in GetPickups())
        {
            if(IsOutlined(pickup.gameObject))
            {
                text += string.Format("Pickup: Name: {0} DisplayName: {1}, ID: {2}", pickup.name, pickup.DisplayName, pickup.PickupObjectId);
                id = pickup.PickupObjectId;
            }
        }
        foreach(var item in GetShopItems())
        {
            if(IsOutlined(item.gameObject))
            {
                text += string.Format("ShopItem: Name: {0} DisplayName: {1}, ID: {2}", item.name, item.item.DisplayName, item.item.PickupObjectId);
                id = item.item.PickupObjectId;
            }
        }

        if(ItemData.Items.ContainsKey(id))
        {
            text += ItemData.Items[id].text;
        }

        label.Text = text;

        label.IsVisible = false;
        label.IsVisible = true;
    }

    private static IEnumerable<PickupObject> GetPickups()
    {
        List<PickupObject> output = new List<PickupObject>();
        foreach(var pickup in Object.FindObjectsOfType<PickupObject>())
        {
            bool debris = pickup.GetComponentInParent<DebrisObject>() != null || pickup.GetComponentInChildren<DebrisObject>() != null;
            if(debris)
                output.Add(pickup);
        }
        return output;
    }

    private static IEnumerable<ShopItemController> GetShopItems()
    {
        return FindObjectsOfType<ShopItemController>();
    }

    private static bool IsOutlined(GameObject gameObject)
    {
        try
        {
            MeshRenderer renderer = gameObject.transform.Find("BraveOutlineSprite").GetComponent<MeshRenderer>();
            Vector4 vector = renderer.material.GetVector("_OverrideColor");
            return vector == Vector4.one;
        }
        catch
        {
            return false;
        }
    }
}