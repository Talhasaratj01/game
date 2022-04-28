using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float speed = 0.6f;
    public Rigidbody2D rb;
    Vector2 Move;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move.x = Input.GetAxis("Horizontal");
        Move.y = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Move * speed * Time.fixedDeltaTime);

    }
}
