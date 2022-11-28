using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;
    public bool empty = true;
    public Transform imageObj;
    public Image image;
    void Start()
    {
        imageObj = gameObject.transform.GetChild(0);
        image = imageObj.GetComponent<Image>();

    }
    void Update()
    {
        if(item != null && !empty)
        {
            if(!image.isActiveAndEnabled)
                {image.enabled = true;
            image.sprite = item.icon;}
        }
    }
    public void OnClickPressed(){
        if(!empty)
            MoveItem();
    }
    public void RemoveItem(){
        item = null;
        empty = true;
        image.sprite = Resources.Load<Sprite>("Mini_background");
        ItemsWindow src = gameObject.transform.parent.GetComponent<ItemsWindow>();
        src.space++;
    }
    public void MoveItem(){
        ItemsWindow dest = null;
        if(gameObject.transform.parent.name.Equals("Backpack"))
            {
                dest = GameObject.Find("Equipment").GetComponent<ItemsWindow>();
            }
        if(gameObject.transform.parent.name.Equals("Equipment"))
            {
                dest = GameObject.Find("Backpack").GetComponent<ItemsWindow>();
            }
        if(gameObject.transform.parent.name.Equals("Loot"))
            {
                dest = GameObject.Find("Backpack").GetComponent<ItemsWindow>();
            }
        if(dest != null)
        {
            
            if(dest.space == 0)
                return;
            Debug.Log(item);
            dest.AddItem(item);
            RemoveItem();
            
        }
    }
}
