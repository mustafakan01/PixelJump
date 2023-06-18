using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jumpForce;
    public bool isJump=true;
    bool isDobuleJump = true;
    public Animator anim;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJump == false)
            {
                rb.AddForce(Vector2.up * jumpForce);
                isJump = true;
                anim.SetBool("Jump", isJump);
            }
        
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.AddForce(Vector2.up * jumpForce);
            isJump = true;
        }
        else if (!isDobuleJump)
        {
            rb.AddForce(Vector2.up * jumpForce);
            isDobuleJump = true;
            anim.SetBool("Jump", isJump);
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Zemin"))
        {
           isJump = false;
            isDobuleJump = false;

        }
    }
}
