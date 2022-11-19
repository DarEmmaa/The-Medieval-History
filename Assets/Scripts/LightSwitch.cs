using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LightSwitch : MonoBehaviour
{

    public GameObject light;

    public bool isLightOff;
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
        if (!isLightOff)
        {
            light.SetActive(false);
            isLightOff = true;

        }
        else
        {
            light.SetActive(true);
            isLightOff = false;
        }
    }
}
