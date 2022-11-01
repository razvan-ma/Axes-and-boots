using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsWindow : MonoBehaviour
{
    int slotsNr;
    List<Slot> slots = new List<Slot>();
    void Start()
    {
        slotsNr = gameObject.transform.childCount;
    }
    // Update is called once per frame
    void Update()
    {
        foreach (Slot slot in slots)
        {
            //slots = gameObject.GetComponentInChildren<Slot>();
        }    
    }
}
