using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    bool jumped;
    public float impulse_force;
    private Rigidbody2D body;
    private Animator anim;
    //private bool isOnTheGround;
    public LayerMask groundLayer;
    public LayerMask wallLayer;
	    // Start is called before the first frame update
    void Start()
    {
        jumped = false;
        impulse_force = 1.5f;
        //isOnTheGround = true;
        anim = GetComponent<Animator>();
        body = this.GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
       // StartCoroutine ("wait_jump", 2);
        //if (jumped)
        //    {
        //        jumped = false;
        //        if (isGrounded()){}
                //body.velocity = new Vector2 (0,body.velocity.y);
        //    }

    }

    public void Clicked()
    {
        
        anim.SetBool("Clicked", true);
        StartCoroutine("wait_animation", 1.5);

    }

    IEnumerator wait_animation (float value)
    {
        yield return new WaitForSeconds(value);
    }

    IEnumerator wait (float value)

    {
        yield return new WaitForSeconds(value);
        anim.SetBool("Clicked", false);

    }


    IEnumerator wait_jump (float value)
    {
        if (isGrounded())
            {
                jump();
                jumped = true;
            }
        yield return new WaitForSeconds(value);

    }

    void jump()
    {
        if(isAWall())
        {
            impulse_force = -impulse_force;
            body.AddForce(new Vector2(impulse_force/2, Mathf.Abs(impulse_force)), ForceMode2D.Impulse);
        }

        body.AddForce(new Vector2(impulse_force/2, Mathf.Abs(impulse_force)), ForceMode2D.Impulse);
    }

    bool isGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1f;
    
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null ) {
            return true;
        }
    return false;
    }

    bool isAWall()
    {
        Vector2 position = transform.position;
        Vector2 Right = Vector2.right;
        Vector2 Left = Vector2.left;
        float distance = 1.0f;
    
        RaycastHit2D hit = Physics2D.Raycast(position, Right, distance, wallLayer);
        RaycastHit2D hit2 = Physics2D.Raycast(position, Left, distance, wallLayer);

        if (hit.collider != null || hit2.collider!= null) {
            return true;
        }
    
    return false;
    }

}
