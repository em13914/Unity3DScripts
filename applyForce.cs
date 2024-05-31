using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyForce : MonoBehaviour
{
    public float forceMagnitude = 10f;

    void Start()
    {

    }

    void Update()
    {
        // Calculate force direction (upward in local space of the ramp)
        Vector3 forceDirection = new Vector3(1f, 2f, -1f);

        // Apply force to the rigidbody of this GameObject
        GetComponent<Rigidbody>().AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
    }
}
