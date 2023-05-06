using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirx * 7f, rb.velocity.y);
        
        if(Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 14f);
        }

        if(dirx > 0f)
        {
            anim.SetBool("running",true);
        }
        else if(dirx < 0f)
        {
            anim.SetBool("running",true);
        }
        else
        {
            anim.SetBool("running",false);
        }
    }
}
