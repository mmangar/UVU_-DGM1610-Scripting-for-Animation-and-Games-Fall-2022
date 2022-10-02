using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Destroy this gameobject
        Destroy(other.gameObject); //Destroy the other gameobject it hits
    }
}
