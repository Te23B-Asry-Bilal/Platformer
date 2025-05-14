using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField]
   float jumpForce = 1000;

   bool mayJump = true;

   [SerializeField]
   Transform groundChecker;

   [SerializeField]
   LayerMask groundLayer;

   [SerializeField]
   float speed;



    void Update()
    {
        
        float xInput = Input.GetAxisRaw("Horizontal");
        Vector2 movment = new Vector2(xInput, 0) * speed * Time.deltaTime;
        
        transform.Translate(movment);
        
        if (Input.GetAxisRaw("Jump") > 0 && mayJump == true && IsGrounded()) 
        {
            
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * jumpForce);
            mayJump = false;

        }

        if (Input.GetAxisRaw("Jump") == 0)
        {
            mayJump = true;
        }

        

    }

    private bool IsGrounded()
    {
     if(Physics2D.OverlapCircle(groundChecker.position, .2f, groundLayer))
     {
      return true;
     }
     else{
        return false;
     }
    
    
    }

}
    
