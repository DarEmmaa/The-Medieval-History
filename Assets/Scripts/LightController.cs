using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleLight()
    {
        if(light.enabled == true)
        {
            light.enabled = false;

        }
        else
        {
            light.enabled = true;
        }
    }
}
