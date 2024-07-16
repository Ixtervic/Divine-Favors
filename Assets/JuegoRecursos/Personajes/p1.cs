using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1 : MonoBehaviour
{
    public float velMov;

    public Rigidbody2D rigidbody2D;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("PressD", true);
            rigidbody2D.velocity = new Vector2(velMov, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("PressA", true);
            rigidbody2D.velocity = new Vector2(-velMov, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("PressS", true);
            rigidbody2D.velocity = new Vector2(0, -velMov);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("PressW", true);
            rigidbody2D.velocity = new Vector2(0, velMov);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("PressD", false);
            StopMovement();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("PressA", false);
            StopMovement();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("PressS", false);
            StopMovement();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("PressW", false);
            StopMovement();
        }
    }
    private void StopMovement()
    {
        rigidbody2D.velocity = Vector2.zero;
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "suelo")
        {
            animator.SetBool("PressD", false);
            animator.SetBool("PressA", false);
            animator.SetBool("PressS", false);
            animator.SetBool("PressW", false);
        }
    }
    /*private void FixedUpdate() 
    {
        float horizontal = Input.GetAxis("Horizontal");
        rigidbody2D.velocity = new Vector2 (horizontal * velMov, 0);
    }*/
}
