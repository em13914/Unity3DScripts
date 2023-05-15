using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
    // onTriggerEnter is called when the detectionZone is entered
    private void OnTriggerEnter(Collider other)
    {
      GameObject.FindWithTag("lisa").AddComponent<upDownPlatform>();
      GameObject.FindWithTag("ball").GetComponent<Renderer>().material.color = Color.green;
      GameObject.FindWithTag("dvcube").AddComponent<Rigidbody>(); 
    }
}
