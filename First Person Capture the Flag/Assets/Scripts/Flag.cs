using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private GameManager gm;

    private Renderer rend;




    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); //Find GameManager and reference the GameManager Component
        rend = GetComponent<Renderer>();
        rend.enabled = true;

    }
     void OntriggeredEnter(Collider other)
    {
        gm.hasFlag = true; //Get flag ans set bool hasFlag to true
        rend.enabled = false;//Hide the Flag 
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
