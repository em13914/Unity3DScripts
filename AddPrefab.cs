using UnityEngine;

public class AddPrefab : MonoBehaviour
{
    public GameObject myPrefab; // Reference to the prefab to instantiate (create)
    public Vector3 prefabPosition; // Where the prefab will spawn

    private void OnCollisionEnter(Collision collision)
    {
        // Make the current GameObject disappear
        Destroy(gameObject);
        Destroy(GameObject.FindWithTag("Pole"));

        // Instantiate (create) the prefab at the specified location
        Instantiate(myPrefab, prefabPosition, Quaternion.identity);

        // OPTIONAL: Instead of adding a new prefab, you could add a built-in sphere GameObject!
        //GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //sphere.transform.position = spherePosition;
        //Rigidbody rb = sphere.AddComponent<Rigidbody>();
    }
}

