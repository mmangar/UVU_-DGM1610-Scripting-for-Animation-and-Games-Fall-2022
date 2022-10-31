using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDropDown : MonoBehaviour
{

    private PlatformEffector2D effector2D;

    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        effector2D = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Resets the wait time when key is released
        if(Input.GetKeyUp(KeyCode.S))
        { 
            waitTime = 0.5f;
        }


        //Fipping effector down  
        if (Input.GetKey(KeyCode.S))
        {
            if (waitTime <= 0) //If wait time is reduced to zero flip effector down
            {
                effector2D.rotationalOffset = 180f; // Flips effector 
                waitTime = 0.5f; // sets wait time
            }
            else
            {
                waitTime -= Time.deltaTime; // Reduces waittime over time
            }

        }
           //Flip effector back up
            if (Input.GetKey(KeyCode.W))
            {
                effector2D.rotationalOffset = 0;
            }
        
    }
}
