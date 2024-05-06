using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChange : MonoBehaviour
{
    // "cam1" is linked to "Camera 1" in the Inspector window
    public GameObject cam1;
    // "cam2" is linked to "Camera 2" in the Inspector window
    public GameObject cam2;
    
    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false); 
    }
    
    private void OnTriggerEnter(Collider other)
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
    }
}
//https://www.youtube.com/watch?v=wWTOuggRvgc&ab_channel=JimmyVegas
//https://www.youtube.com/watch?v=9lPCv9kkbSI&ab_channel=JimmyVegas
