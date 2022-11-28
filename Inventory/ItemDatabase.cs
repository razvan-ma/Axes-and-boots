using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDatabase : MonoBehaviour
{
    private void Awake()
    {
        BuildDatabase();
    }
    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }
    public Item GetItem(string name)
    {
        return items.Find(item => item.itemName == name);
    }
    List<Item> items = new List<Item>();
    void BuildDatabase()
    {
        items = new List<Item> {
                new Item(0, "Weapon",Resources.Load<Sprite>("Iron Sword"), "Iron Sword",
                new Dictionary<string, int>
                {
                    {"Attack",5}
                }),
                new Item(1, "Armor",Resources.Load<Sprite>("dragon"), "Platemail",
                new Dictionary<string, int>
                {
                    {"Armor", 10}
                })
            };
    }
    void Start()
    {
    }
}
