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
}
