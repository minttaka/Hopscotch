using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_move : MonoBehaviour 
{
  public float maxSpeed;
  public Vector2 jumpHeight;
  public Rigidbody2D rb;
  
  private bool goingUp = false;
  private bool isGrounded = true;
  private float nextJump;
	
	// Use this for initialization
	void Start () 
	{
        rb = GetComponent<Rigidbody2D>();
  }

    IEnumerator OnCollisionExit2D(Collision2D coll)
	{	
   		if (goingUp == true && coll.gameObject.name == "spr_platform")
    	{
    		 yield return new WaitForSeconds(1/2);
    		 Destroy(coll.gameObject);
    	};
	}

	
	void OnCollisionEnter2D(Collision2D coll)
	{
		
	}

	void Update ()
	{
		rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);

        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(moveHorizontal, 0f);
		rb.AddForce(move * maxSpeed * 3);

		if(Input.GetKeyDown("up") && isGrounded && Time.time >= nextJump) 
        {
   			goingUp = true;
   			rb.AddForce(jumpHeight, ForceMode2D.Impulse);
   			nextJump = Time.time + 0.8f;
   		};

		if(transform.position.y >= maxSpeed)
        {
           rb.velocity = new Vector2(rb.velocity.x, 0);
 		};
	}
}