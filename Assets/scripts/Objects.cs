using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
   private float movespeed;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        movespeed = 1;
        rb.velocity = Vector2.left * movespeed;

    }
    
       
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -15f){
            Destroy(gameObject);
        }
    }
}
