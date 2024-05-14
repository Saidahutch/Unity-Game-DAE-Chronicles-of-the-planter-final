using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class JumpsControler : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
   [SerializeField] int jumpPower;
    // bool canJump = true; // Flag to track if the character can jump

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {

        if(Input.GetKeyDown("space"))
        {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

    }
  
}
