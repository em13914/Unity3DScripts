using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnGreen : MonoBehaviour
{
    private Color purp;

    // Start is called before the first frame update
    void Start()
    {
      purp = new Color32(153, 50, 204, 255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
      // Use the Console to understand what your code is doing
      Debug.Log("HIT DETECTED!");

      // Remove any material already on the GameObject
      // GetComponent<Renderer>().material = null;

      // Here's where you can find other ways you can change the renderer of any object
      // https://docs.unity3d.com/ScriptReference/Renderer.html

      GetComponent<Renderer>().material.color = Color.green;
      GameObject.FindWithTag("plat").GetComponent<Renderer>().material.color = purp;

    }
}
