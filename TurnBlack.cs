using UnityEngine;

public class TurnBlack : MonoBehaviour
{
    void Start()
    {
        // print at the beginning so we know the script is running
	UnityEngine.Debug.Log("Starting...");
    }

    void OnCollisionEnter(Collision other)
    {
        // print when there's a collision so we know the script recognizes hits
        UnityEngine.Debug.Log("HIT!!!!!!!!!!!!!!!!");
	GetComponent<Renderer>().material.color = Color.black;
    }
}
