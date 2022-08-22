﻿using UnityEngine;

public class WalkingSimulator : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed = 5;
    public float JumpForce = 7;
    public bool facingRight = true;
    /*public Animator animator;*/
    

    // RIGIDBODY 2D
    public Rigidbody2D _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        // KODE MOVEMENT
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        // KODE FLIP MOVEMENT
        if (movement < 0 && facingRight) Flip();
        if (movement > 0 && !facingRight) Flip();
        // KODE LOMPAT
        /*if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }*/
        // ANIMATOR
        /*if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("Run", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Run", false);
        }*/
        // ESCAPE

        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("pause");
        } */
    }
    // KODE FLIP MOVEMENT
    private void Flip()
    {
        facingRight = !facingRight;
       
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
}