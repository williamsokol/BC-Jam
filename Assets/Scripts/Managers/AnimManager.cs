using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{

    public PlayerMovement playerMovement;
    public Animator animator;

    float horizontal;

    
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal  = Input.GetAxisRaw("Horizontal");
        if (playerMovement.IsGrounded())
        {
            animator.SetBool("In the air", false);
        }else {
            animator.SetBool("In the air", true);
        }
        
        animator.SetBool("Crouched", playerMovement.crouched);
        

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
