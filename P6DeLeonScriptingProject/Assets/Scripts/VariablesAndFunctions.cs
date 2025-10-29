using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{

    //create an ineger variable
    int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {
        //im going to run the variable  to my funnction
        myInt = MultiplyByTwo(myInt);
        //display the variable through my functon
        Debug.Logs(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //creating my funtion

    int MultiplyByTwo(int number)
    {
        //create a results variable
        int result;
        result = number * 2;
        //return the result
        return result;

    }
}
