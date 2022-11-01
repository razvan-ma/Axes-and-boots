using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{
    Rigidbody2D houseRb;
    float movementSpeed = 4;
    public Animator animator;
    private Vector2 movementUpdate;
    float x, y;
    SpriteRenderer sr;
    void Start()
    {
        houseRb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponentInChildren<SpriteRenderer>();
    }
    
    void Update()
    {

        //animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        //animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Vertical")));
        if (Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0 || Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0)
            animator.SetBool("IsRunning", true);
        else
            animator.SetBool("IsRunning", false);
        if (Input.GetAxisRaw("Horizontal") < 0)
            sr.flipX = true;
        else if(Input.GetAxisRaw("Horizontal") > 0)
                sr.flipX = false;
        Vector2 movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        movementUpdate = movementInput.normalized * movementSpeed;
    }

    private void FixedUpdate()
    {
        houseRb.MovePosition(houseRb.position + movementUpdate * Time.fixedDeltaTime);
    }
}