using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadFollow : MonoBehaviour
{
    public Transform cam;
    
    public float isPlayer = 1;
    Vector3 padPos = new Vector3(2.71f, -0.4f, 0f);
    void Start()
    {
        padPos = new Vector3(2.71f * isPlayer, -0.4f, 0f);
        cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    void Update()
    {
        gameObject.transform.position = new Vector3(cam.position.x + padPos.x, cam.position.y + padPos.y, 0f);
    }
}
