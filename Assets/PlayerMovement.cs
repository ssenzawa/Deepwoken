using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    private float moveInput;

    private Rigidbody2D _rigidbody;

    private bool facingRight = true;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

            if(facingRight == false && moveInput > 0)
            {
                Flip();
                {
                    if(facingRight == true && moveInput < 0)
                    {
                        Flip();
                    }
                }
            }
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 = Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
