using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string type;
    public string itemName;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();
    public Item(int id, string type, Sprite icon, string itemName, Dictionary<string, int> stats)
    {
        this.id = id;
        this.type = type;
        this.itemName = itemName;
        this.icon = icon;
        this.stats = stats;
    }
    public Item(Item item)
    {
        id = item.id;
        type = item.type;
        itemName = item.itemName;
        icon = item.icon;
        stats = item.stats;
    }
    public void SpawnItem(Slot slot)
    {
        for (int i = 0; i < slot.gameObject.gameObject.transform.childCount; i++)
        {
            if (slot.empty == true)
            {
                slot.gameObject.gameObject.transform.GetChild(i).GetComponent<Slot>().item = this;
                slot.gameObject.gameObject.transform.GetChild(i).GetComponent<Slot>().empty = false;
            }
        }

    }
}
