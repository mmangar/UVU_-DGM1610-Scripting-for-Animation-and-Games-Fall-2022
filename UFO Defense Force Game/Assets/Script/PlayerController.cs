using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 25;

    public float xRange = 15;

    public Transform blaster;

    public GameObject boltContainer;


    // Update is called once per frame
    void Update()
    {
        //Set horizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        //Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //Keep player with in bounds
        //Left side wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // If space bar is pressed fire boldContainer
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Create boltContainer at the Blaster transform position maintaining the object rotation.
            Instantiate(boltContainer, blaster.transform.position, boltContainer.transform.rotation);
        }


    }

        //Delete any object with a trigger that hits the player
        private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }


}
