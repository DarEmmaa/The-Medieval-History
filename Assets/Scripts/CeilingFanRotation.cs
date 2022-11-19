using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingFanRotation : MonoBehaviour
{
    public float fanSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, fanSpeed * Time.deltaTime, 0);
    }
}
