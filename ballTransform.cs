using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballTransform : MonoBehaviour
{
    //This variable is public so that it will appear in the Inspector. The type of variable, Vector3, is a data type for holding three values.
    public Vector3 scaleChange;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
	// Set the x,y,z rate of change here in the code instead of the Inspector
	scaleChange = new Vector3(0.005f, 0.005f, 0.005f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x < 10f)
		{	
			//The operator += will add the values in scaleChange to the current scale values of the GameObject, so that the ball grows.
			transform.localScale += scaleChange;
		}
		else
		{
			Debug.Log("Max Size Achieved.");
		}
		//This tracks the exact Vector3 position of the sphere so you can add platforms and obstacles
		Debug.Log("Sphere: " + transform.position);
    }
}
