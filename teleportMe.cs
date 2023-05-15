using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportMe : MonoBehaviour
{
    public Vector3 targetPosition; // The position where you want the sphere to move

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector3(0f, 86.36f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Upon collision with another GameObject, another GameObject will turn green
    private void OnTriggerEnter(Collider other)
    {
        // Use the Console to understand what your code is doing
        Debug.Log("HIT DETECTED!");
	
	// Move the ball to the new location!
	GameObject.FindWithTag("ball").transform.position = targetPosition;
	
	// Reset the velocity to zero once the ball arrives at the new location
	// Rigidbody ballRigidbody = GameObject.FindWithTag("ball").GetComponent<Rigidbody>();
	// ballRigidbody.velocity = Vector3.zero;
    }
}
