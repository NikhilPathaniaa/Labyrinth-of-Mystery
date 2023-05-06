using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;

    private float dirx; // player side ways movement
    [SerializeField] private float moveSpeed =7f;
    [SerializeField] private float jumpSpeed =14f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirx * moveSpeed, rb.velocity.y);
        
        if(Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }

        UpdateAnimationState();
    }
    // UpdateAnimationUpdate is called for animation
    public void UpdateAnimationState()
    {
        if(dirx > 0f)
        {
            anim.SetBool("running",true);
            sprite.flipX =false;
        }
        else if(dirx < 0f)
        {
            anim.SetBool("running",true);
            sprite.flipX =true;
        }
        else
        {
            anim.SetBool("running",false);
        }   
    }
}
