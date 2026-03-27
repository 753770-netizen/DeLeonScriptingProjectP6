using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{

    public Rigidbody rockectPrefab;
    public Transform barrelEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rockectPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * 5000);
        }
    }
}
