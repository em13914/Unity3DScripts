using UnityEngine;

public class GrowingSphere : MonoBehaviour
{
    public Vector3 scaleChange;
    
    void Start()
    {
        // Set the x,y,z rate of change here in the code instead of the Inspector
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
    }

    void Update()
    {
        if (transform.localScale.x < 10f) {
            //The operator += will add the values in scaleChange to the current scale values of the GameObject, so that the ball grows.
            transform.localScale += scaleChange;
        } else {
            UnityEngine.Debug.Log("Maximum size reached!");
        }

    }
}
