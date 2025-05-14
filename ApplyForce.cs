using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    // Choose a direction and speed for the force you want to apply
    private Vector3 force = new Vector3(0f, 0f, 0f); // Set your direction and speed here

    void FixedUpdate()
    {
        // Set velocity directly every physics update (ignores mass or physics forces)
        GetComponent<Rigidbody>().linearVelocity = force;
    }
}
