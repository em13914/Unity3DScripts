using UnityEngine;

public class SoundCollision : MonoBehaviour
{
    private AudioSource audioSource;

    void OnCollisionEnter(Collision other)
	{
        // play the sound when the object collides with another object
        GetComponent<AudioSource>().Play();
	}
}
