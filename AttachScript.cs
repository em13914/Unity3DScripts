using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachScript : MonoBehaviour
{
    // onTriggerEnter is called when the detectionZone is entered
    private void OnTriggerEnter(Collider other)
    {
      GameObject.FindWithTag("lisa").AddComponent<upDownPlatform>();
      GameObject.FindWithTag("ball").GetComponent<Renderer>().material.color = Color.green;
      GameObject.FindWithTag("dvcube").AddComponent<Rigidbody>(); 
    }
}
