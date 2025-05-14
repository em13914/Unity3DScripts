using UnityEngine;

public class CameraChange : MonoBehaviour
{
    // Set the cameras in the Unity Editor
    public GameObject oldCam;
    public GameObject newCam;

    // When the "trigger zone" is entered, switch cameras
    private void OnTriggerEnter(Collider other)
    {
        oldCam.SetActive(false);
        newCam.SetActive(true);
    }
}
