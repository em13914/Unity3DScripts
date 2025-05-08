using UnityEngine;

public class TurnBlackCollision : MonoBehaviour
{
    void Start()
    {
        // print at the beginning so we know the script is running
        UnityEngine.Debug.Log("Starting...");
    }
	
	void OnCollisionEnter(Collision other)
	{
        // find the object this script is attached to and change the color to black
        GetComponent<Renderer>().material.color = Color.black;
	}
}
