using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;

    public GameObject backpack;
    public GameObject loot;
    public GameObject equipment;
    public bool empty = true;
    public Sprite buttonImage;
    void Update()
    {           
    }
    void Start()
    {
        //icon = item.icon;
        //buttonImage.sprite = null;
        buttonImage = Resources.Load("Assets/") as Sprite;
    }

    public void OnClickPressed()//sincer nu stiu altfel
    {

        if (item != null)
        {
            if(gameObject.GetComponentInParent<LootTable>()) 
            {
                MoveItem(this, backpack.GetComponentInChildren<Slot>());
            }
            if (gameObject.GetComponentInParent<StatsManager>())
            {
                MoveItem(this, backpack.GetComponentInChildren<Slot>());
            }
            if (gameObject.transform.parent.name == "Backpack")
            {
                MoveItem(this, equipment.GetComponentInChildren<Slot>());
            }
        }


    }
    void MoveItem(Slot currentSlot,Slot moveSlot)
    {
        
        if (moveSlot.empty)
        {
            Debug.Log(currentSlot.item.icon);
            moveSlot.transform.GetChild(0).GetComponent<Image>().sprite = currentSlot.item.icon;
            currentSlot.empty = true;
            moveSlot.empty = false;
            moveSlot.item = currentSlot.item;
            currentSlot.item = null;
            moveSlot.transform.GetChild(0).GetComponent<Image>().enabled = true;
            
            currentSlot.GetComponent<Image>().sprite = buttonImage;
            //currentSlot.transform.GetChild(0).GetComponent<Image>().sprite = buttonImage;
            currentSlot.transform.GetChild(0).GetComponent<Image>().enabled = false;
            
        }
}
}
