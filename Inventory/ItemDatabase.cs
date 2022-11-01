using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDatabase : MonoBehaviour
{
    public Slot lootSlot;
    public Sprite sprite;
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
                new Item(0, "Equipment",Resources.Load("Assets/Resources/Iron Sword") as Sprite, "Iron Sword",
                new Dictionary<string, int>
                {
                    {"Attack",5}
                })
            };
    }
    void Start()
    {
        lootSlot.item = GetItem(0);
        lootSlot.gameObject.transform.GetComponentInChildren<Image>().sprite = sprite;
        Debug.Log(lootSlot.item.itemName);
    }
}
