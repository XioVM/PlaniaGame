using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;


    private void Awake()
    {
        //referencias para rigidbody y animator 
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(3, 3, 3);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-3, 3, 3);

        if (Input.GetKey(KeyCode.Space) && grounded)
            Volando();

        //set animator parametros
        //el horizontal input significa que no estas necesitandola ahorita
        anim.SetBool("Run", horizontalInput != 0);
        anim.SetBool("grounded", grounded);

    }

    private void Volando()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        anim.SetTrigger("volando");
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }



}

