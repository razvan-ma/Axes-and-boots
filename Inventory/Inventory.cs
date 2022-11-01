using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool inventoryEnabled;
    public GameObject backpack;
    public GameObject equipment;

    private int allSlots;
    private int enabledSlots;
    private GameObject[] slot;


    void Start()
    {
        //allSlots = 12;
        //slot = new GameObject[allSlots];    
        //for(int i=1; i < allSlots; i++)
        //{
        //    slot[i] = slotHolder.transform.GetChild(i).gameObject;
        //}

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            if (inventoryEnabled)
                inventoryEnabled = false;
            else
                inventoryEnabled = true;

        if (inventoryEnabled)
        {
            backpack.SetActive(true);
            equipment.SetActive(true);
        }
        else
        {
            backpack.SetActive(false);
            equipment.SetActive(false);
        }
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "item")
    //    {
    //        GameObject itemPickedUp = other.gameObject;
    //        Item item = itemPickedUp.GetComponent<Item>();

    //        AddItem(item.ID, item.type, item.description, item.);
    //    }

    //}
    public void EquipItem(Item item)
    { 
        bool equipped=false;
        if(equipped)
        {
            equipped = !equipped;
        }
    }
}
