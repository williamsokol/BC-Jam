using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    public PlayerMovement playerMovement;
    
    public Rigidbody2D rb;
    public Animator animator;

    float horizontal;

    
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal  = Input.GetAxisRaw("Horizontal");
        if (playerMovement.IsGrounded())
        {
            animator.SetBool("Jumping", false);
            

        }else {
            if(rb.velocity.y > 0)
            {
                animator.SetBool("Falling", false);
            }else{animator.SetBool("Falling", true);}


            animator.SetBool("Jumping", true);
        }
        
       // check if dancing

        if(PlayerDance.DanceState > 0)
        {   
            print(PlayerDance.DanceState);
            
            animator.SetBool("Is Dancing", true);
            animator.SetInteger("Dance State",PlayerDance.DanceState);
            
            
        }else{
            animator.SetBool("Is Dancing", false);
        }
        

    }
    void Update()
    {
        if( playerMovement.movement != 0){
            animator.SetBool ("Running",true);
            if(horizontal == 1){
                transform.localScale =  new Vector2(1,transform.localScale.y);
            }else if(horizontal == -1){
                transform.localScale =  new Vector2(-1,transform.localScale.y);
            }
        }else{
            animator.SetBool ("Running",false);
        }
    }
}
