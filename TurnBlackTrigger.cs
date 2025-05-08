using UnityEngine;

public class TurnBlackTrigger : MonoBehaviour
{
    void Start()
    {
        // print at the beginning so we know the script is running
        UnityEngine.Debug.Log("Starting...");
    }
	
	void OnTriggerEnter(Collider other)
    {
        // find the object tagged "Player" and change the color to black
        GameObject.FindWithTag("Player").GetComponent<Renderer>().material.color = Color.black;
	}
}
