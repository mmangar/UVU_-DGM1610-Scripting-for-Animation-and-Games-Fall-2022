using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

   private ScoreManager scoreManager; // A variable to hold the reference to the socremanager 

    public int scoreToGive;

    public ParticleSystem explosionParticle;


    //Start is called the before the first frame update

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Rerefence  score manager
        explosionParticle.Stop();
    }




    void OnTriggerEnter(Collider other) // Once the trigger has been entered record collision in the argument variables "other"
    {
        explosionParticle.Play();
        scoreManager.IncreaseScore(scoreToGive); //Increase Score amount by scoreToGive
        Destroy(other.gameObject); //Destroy this gameobject
        Destroy(gameObject); //Destroy the other gameobject it hits
        
        
    }

}
