using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D rb;
   private Animator an;
   private SpriteRenderer sprite;
   private BoxCollider2D co;  


   private float dirx =0f;
   [SerializeField] private float speedMove=7f;
   [SerializeField] private float forceJump =14f;
   [SerializeField] private LayerMask GroundJumpable;

   private enum StateOfMovement { idle, running, jumping, falling}
//    private StateOfMovement state = StateOfMovement.idle;


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an= GetComponent<Animator>();
        sprite= GetComponent<SpriteRenderer>();
        co= GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //getAxisRaw makes character stop straight away
         dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirx * speedMove, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && onGround())
        {
            rb.velocity = new Vector2(rb.velocity.x,forceJump);
        }

        UpdatingAnimation();
   
    }

    private void UpdatingAnimation()
    {
        StateOfMovement state;


        //check if running right
        if(dirx > 0f) 
        {
            // an.SetBool("running",true);
            state=StateOfMovement.running;
            sprite.flipX =false;
        }

        //running left direction
        else if(dirx < 0f)
        {
            // an.SetBool("running",true);
            state=StateOfMovement.running;
            sprite.flipX =true;
        }

        //not running
        else
        {
            // an.SetBool("running",false);
            state=StateOfMovement.idle;
        }

        //if jumping
        if(rb.velocity.y > .1f)
        {
            state=StateOfMovement.jumping;
        }

        //falling
        else if (rb.velocity.y < -.1f)
        {
            state=StateOfMovement.falling;
        }

        an.SetInteger("state",(int)state);

    }

    //metod to stop double jumping
    private bool onGround()
    {
        return Physics2D.BoxCast(co.bounds.center, co.bounds.size, 0f, Vector2.down, .1f, GroundJumpable);
    }

}
