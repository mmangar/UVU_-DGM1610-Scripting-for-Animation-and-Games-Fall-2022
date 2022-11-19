using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Movement")]
    public float moveSpeed;

    public float jumpForce;

    [Header("Camera")]

    public float lookSensitivity;

    public float maxLookX;

    public float minLookX;

    private float rotX;

    private Camera camera;

    private Rigidbody rb;

    void Awake()
    {
        //Get Components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraLook();


        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;// Getting Input for left and right Movement 
        float z = Input.GetAxis("Vertical") * moveSpeed;//Getting Input for forward and backward movement

        //Vector3 dir = transform.right *
        //rb.velocity = new Vector3(x, rb.velocity.y, z);//Apply velocity to the x-axis and z-axis to drive the player 
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity; // Look up and down 
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity; // Look left and Right

        //Restrict rotation on the x-asixs between maxLook to minLook
        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);

        // drives Camera rotation
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void Jump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);


        if(Physics.Raycast(ray, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
