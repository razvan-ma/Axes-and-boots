using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTr;
    public Camera cameraCm;
    //public RefVars rv;
    public float cameraDampTime;
    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        //Player follow
        Vector3 point = cameraCm.WorldToViewportPoint(playerTr.position);
        Vector3 delta = playerTr.position - cameraCm.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
        Vector3 destination = transform.position + delta;
        transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, cameraDampTime);
    }

    void Update()
    {
        //Zoom in and out
        //float newZoom = cameraCm.orthographicSize + Input.mouseScrollDelta.y * rv.env.cameraZoomSens * -1;
        //cameraCm.orthographicSize = Mathf.Clamp(newZoom, rv.env.cameraZoomInLimit, rv.env.cameraZoomOutLimit);
    }
}
