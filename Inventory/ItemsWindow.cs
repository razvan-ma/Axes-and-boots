using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsWindow : MonoBehaviour
{
    public int space;
    public int size;

    void Start(){
        size = gameObject.transform.childCount;
        space = size;
    }
    public GameObject GetSlot(int index){
        Transform childTrans;
        if(index == 0)
            childTrans =  gameObject.transform.Find("Slot");
        else
            childTrans =  gameObject.transform.Find("Slot (" + index.ToString() + ")");
        if (childTrans != null)
            return childTrans.gameObject;
        else
            return null;
    }
    public void AddItem(Item item){
        if(space == 0)
            {
                Debug.Log("INVENTORY IS FULL");
                return;
            }
        Slot slot = GetSlot(size - space).gameObject.GetComponent<Slot>();
        space--;
        Debug.Log(item.itemName);
        slot.item = item;
        slot.empty = false;
    }
    public void MoveItem(ItemsWindow dest){
        AddItem(GetSlot(size - space).GetComponent<Item>());

    }
}
