using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public Vector3 velocity = new Vector3(0f, 0f, -2f); // Set your direction and speed here

    void FixedUpdate()
    {
        // Set velocity directly every physics update (ignores mass or physics forces)
        GetComponent<Rigidbody>().linearVelocity = velocity;
    }
}
