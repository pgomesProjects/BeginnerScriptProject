using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{

    //Light GameObject
    public Light pointLight;
    bool toggleLight;

    // Start is called before the first frame update
    void Start()
    {
        toggleLight = true;
    }

    // Update is called once per frame
    void Update()
    {

        //If the "L" key is pressed, then toggle the light on and off
        if (Input.GetKeyDown(KeyCode.L))
        {
            //If true, make false. If false, make true
            toggleLight = !toggleLight;
            pointLight.enabled = toggleLight;

        }
    }
}
