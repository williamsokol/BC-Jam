using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private LayerMask groundLayerMask;
    public Rigidbody2D rb;
    public BoxCollider2D boxCollider;
    
    public Animator animator;

    [HideInInspector] public float movement;
    public float moveSpeed = 5;
    public float jumpForce = 5;
    
    //public bool crouched;

    // Start is called before the first frame update
    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        

    }

   
    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector2 (Input.GetAxisRaw("Horizontal"),transform.position.y);
        movement = Input.GetAxisRaw("Horizontal") *  moveSpeed/100;
        
        

        //See if the jumping
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.AddForce(transform.up * jumpForce);
            
        }
        
        
        
    }
    void FixedUpdate()
    {
        transform.Translate( Vector2.right * movement);
    }
    public bool IsGrounded()
    {
        float extraHeightText = 0.1f;
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, extraHeightText, groundLayerMask);
        //Color rayColor;
        
        //Debug.DrawRay(cc.bounds.center, Vector2.down * (cc.bounds.extents.y + extraHeightText));
        //Debug.Log(hit.collider);
        return hit.collider != null;
    }

    
    




}
