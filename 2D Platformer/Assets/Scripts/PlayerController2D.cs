using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{

    // Player Stats

    public float speed;

    public float jumpForce;

    private float moveInput;


    // Player Rigidbody

    private Rigidbody2D rb;

    private bool isFacingRight = true;


    //Player Jump
    /*
    private bool isGrounded = true;
    public Transform groundCheck;
    public float checkRadius;
    public Layermask whatisGround;


    public bool doubleJump;
    */


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
