using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This first line is going to telll me the x location of my gameobject
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //Make an if statement that checks the hieght of my object
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground");
        }
    }
}
