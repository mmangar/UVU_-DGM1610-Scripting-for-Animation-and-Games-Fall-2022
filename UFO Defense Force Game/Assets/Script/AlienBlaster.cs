using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBlaster : MonoBehaviour
{

    public GameObject LaserBolt;

    public Transform alienBlaster;


    public float startDelay;

    public float spawnInterval;




    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AlienShoot", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AlienShoot()
    {
        Instantiate(LaserBolt, alienBlaster.transform.position, LaserBolt.transform.rotation);
    }
}
