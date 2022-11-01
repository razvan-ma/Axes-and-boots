using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    Unit p;
    void Awake()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Unit>();
    }

    void Update()
    {
        
    }
}
