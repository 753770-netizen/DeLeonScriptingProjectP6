using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, 8f, 0.5f * Time.deltaTime);
    }
}
