using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    //Time specified before the object is destroyed
    public float timeBeforeDestruction;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy the object after a specified amount of seconds
        Destroy(gameObject, timeBeforeDestruction);
    }
}
