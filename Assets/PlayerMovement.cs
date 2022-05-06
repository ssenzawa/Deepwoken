using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce; //All 3 are values for my game, each has its own function e.g speed so you can specifically set the speed, jump height, and moveInput is to detect movement input
    private float moveInput;

    private Rigidbody2D rb; //The 2D rigidbody that my character uses

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround; //All 4 are detecting that my character is either on the ground, is grounded, and to see the radius that my character is within and to defy what ground is

    private int extraJumps; //Adds extra jumps, up to inf amount probably but im using 1 extra jump for doublejump
    public int extraJumpsValue; //The value that extra jumps are set at


    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); //Checks to see if the circle radius is touching the ground or not



        moveInput = Input.GetAxis("Horizontal");
        Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y); //Character movement scripts

        if(facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if(facingRight == true && moveInput < 0)
        {
            Flip(); //Both used for flipping my character left to right or right to left when input is detected 
        }
    }

    void Update()
    {
        if(isGrounded == true)
        {
            extraJumps = extraJumpsValue; //If character is grounded extrajump equals the extrajumpvalue 
        }


        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce; 
            extraJumps--;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true) //Gets input from UpArrow key to jump
        {
            rb.velocity = Vector2.up * jumpForce; //Script for extra jumps, double jumps
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale; //Detects if character is facing right and flips it?
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
