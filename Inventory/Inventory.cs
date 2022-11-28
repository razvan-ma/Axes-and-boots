using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // can be anything, mob drops, shop
    public ItemsWindow loot; 
    
    // these 2 do not change 
    public ItemsWindow backpack; 
    public ItemsWindow equipment;

    private ItemDatabase database;
    void Start(){
        backpack = GameObject.Find("Backpack").GetComponent<ItemsWindow>();
        equipment = GameObject.Find("Equipment").GetComponent<ItemsWindow>();
        database = gameObject.GetComponent<ItemDatabase>();
        for(int i= 0;i < 16;i++)
            backpack.AddItem(database.GetItem(0));
    }
    //new Item(1,"weapon",Resources.Load("Assets/Resources/Iron Sword") as Sprite ,"axe",new Dictionary<string, int>())
    void Update(){
        
        if(Input.GetKeyDown("e")){
            if(backpack.gameObject.activeInHierarchy == false)
                {
                    backpack.gameObject.SetActive(true);
                    equipment.gameObject.SetActive(true);
                }
                else
                {
                    backpack.gameObject.SetActive(false);
                    equipment.gameObject.SetActive(false);
                }
        }
    }
}
