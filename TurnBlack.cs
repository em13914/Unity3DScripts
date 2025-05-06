using UnityEngine;

public class TurnBlack : MonoBehaviour
{
    void Start()
    {
        // print at the beginning so we know the script is running
        UnityEngine.Debug.Log("Starting...");
    }

    void Update()
    {
        
    }
	
	void OnCollisionEnter(Collision other)
	{
        UnityEngine.Debug.Log("HIT!!!!!!!!!!!!!!!!");
        GetComponent<Renderer>().material.color = Color.black;
	}
}
