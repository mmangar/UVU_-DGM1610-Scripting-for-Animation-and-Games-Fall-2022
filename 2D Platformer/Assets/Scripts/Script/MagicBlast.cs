using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBlast : MonoBehaviour
{
    public float speed = 30f;

    public int damage = 10;

    public Rigidbody2D rb;
 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Referejce the rigidbody2D component
      
        rb.velocity = transform.right * speed;//this line of code add velocity and make the gameobject move forward


        // Dectect any collision and triggers 
        void OnTriggerEnter2D(Collider2D other)
        {
            Enemy enemy = other.GetComponent<Enemy>();

            if (other.gameObject.CompareTag("Enemy"))
            {
                enemy.TakeDamage(damage); // Run the TakeDamage fuction and apply damage to enemy

            }

            Destroy (gameObject); //Destroy projectile
        }
    }
}