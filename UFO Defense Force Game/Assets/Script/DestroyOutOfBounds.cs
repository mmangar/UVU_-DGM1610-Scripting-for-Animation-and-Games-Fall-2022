using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBounds = 30.0f;

    public float lowerBounds = -10.0f;

    private ScoreManager scoreManager;

    private DetectCollision detectCollision;


    //Start is the called before the forst frame update

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        detectCollision = GetComponent<DetectCollision>();
    }

    void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

    else if(transform.position.z < lowerBounds)
        {
            scoreManager.DecreaseScore(detectCollision.scoreToGive); // Everytime a ship sneeks past the lower bounds deduct points 
            Debug.Log("Game Over!");
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
