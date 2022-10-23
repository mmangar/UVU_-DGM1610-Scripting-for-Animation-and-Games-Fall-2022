using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

   private ScoreManager scoreManager; //Referencing the scoremanager

    public int scoreToGive;


    //Start is called the before the first frame update

    void start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Rerefence  score manager
    }




    void OnTriggerEnter(Collider other) // Once tbe trigger has been entered record collision in the argument variables "other"
    {
        scoreManager.IncreaseScore(scoreToGive); //Increase Score amount by scoreToGive
        Destroy(other.gameObject); //Destroy this gameobject
        Destroy(gameObject); //Destroy the other gameobject it hits   
    }
}
