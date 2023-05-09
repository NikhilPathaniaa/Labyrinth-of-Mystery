using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private BoxCollider2D coll;

    [SerializeField] private LayerMask jumpableGround;
    private float dirx; // player side ways movement
    [SerializeField] private float moveSpeed =7f;
    [SerializeField] private float jumpSpeed =14f;

    private enum MovementState {idle, running, jumping, falling}// here enumm is used to create our own datatype for animation like rigidbody
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirx * moveSpeed, rb.velocity.y);
        
        if(Input.GetKeyDown("space") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }

        UpdateAnimationState();
    }
    // UpdateAnimationUpdate is called for animation
    public void UpdateAnimationState()
    {
        MovementState state;
        if(dirx > 0f)
        {
            state = MovementState.running;
            sprite.flipX =false;
        }
        else if(dirx < 0f)
        {
            state = MovementState.running;
            sprite.flipX =true;
        }
        else
        {
            state = MovementState.idle;
        }   
        if(rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if(rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }
        anim.SetInteger("state",(int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
