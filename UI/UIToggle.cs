using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIToggle : MonoBehaviour
{
    public GameObject cp;
    
        
        
    void Update()
    {
        if(Input.GetKeyDown("c"))
        {
            cp.SetActive(true);
        }
        if(Input.GetKeyUp("c"))
        {
            cp.SetActive(false);
        }
    }
}
