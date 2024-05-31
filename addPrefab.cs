using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPrefab : MonoBehaviour
{
    // Reference to the prefab to instantiate - set this in the Editor
    public GameObject myPrefab;
    // Position to instantiate the prefab
    public Vector3 prefabPosition;

    void Start()
    {

    }

    void Update()
    {

    }

    // Upon touching with another GameObject the prefab will be created at your specified location
    private void OnTriggerEnter(Collider other)
    {
        // Use the Console to understand what your code is doing
        Debug.Log("TRIGGER!");

        // Instantiate the prefab at the specified position
        Instantiate(myPrefab, prefabPosition, Quaternion.identity);
    }
}
