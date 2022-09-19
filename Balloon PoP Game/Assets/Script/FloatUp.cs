using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{

    public float moveSpeed; // Speed at which the balloon will move upwards


    public float upperBound; // Top boundary for when the balloon exist the screen it will get destroyed 

    private Balloon balloon; // Reference the balloon gameobject

    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        balloon = GetComponent<Balloon>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the balloon upwards
        transform.Translate(Vector3.up * moveSpeed* Time.deltaTime);

        // Destroyed balloon if it passes the top boundry
        if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);
            Destroy(gameObject);
        }
    }
}
