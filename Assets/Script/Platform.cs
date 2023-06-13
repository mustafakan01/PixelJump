using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 5;
    BoxCollider2D box;
    public float groundWithd;
    public static Rigidbody2D rb;
    Vector2 vec;

    
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        groundWithd = box.size.x;
        vec=transform.position;
    }

    
    void Update()
    {
        transform.position=new Vector2(transform.position.x-speed*Time.deltaTime, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obje"))
        {
            transform.position = vec;
        }
    }
}
