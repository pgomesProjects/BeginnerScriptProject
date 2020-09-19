using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Array of objects that can be spawned
    public GameObject[] spawnedPrefabs;
    
    //Uses enums to define the ranges for the different objects
    enum MaxLimit {X = 10, Y = 10, Z = 20};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the "S" key is held down, spawn a new prefab at a random location above the plane
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Randomly generates the location of the object, but remains above the plane (Y = 0.5)
            Vector3 spawnPos = new Vector3(Random.Range(-(float)MaxLimit.X, (float)MaxLimit.X), Random.Range(0.5f, (float)MaxLimit.Y), Random.Range(-(float)MaxLimit.Z, (float)MaxLimit.Z));
            //The index variable for which object will be spawned
            int indexChosen = Random.Range(0, spawnedPrefabs.Length);
             //Create a new random object
            GameObject newObject = Instantiate(spawnedPrefabs[indexChosen], spawnPos, spawnedPrefabs[indexChosen].transform.rotation);

            //If the object is a cube, give it a random color
            if(indexChosen == 0)
                newObject.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }
}
