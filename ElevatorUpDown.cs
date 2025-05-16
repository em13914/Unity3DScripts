using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorUpDown : MonoBehaviour
{
    //declare your variable
    public Vector3 positionChange;

    void Start()
    {
      //assign your Vector3(x, y, z) variable
      positionChange = new Vector3(0, 1, 0); //move the playform UP
    }

    void Update()
    {
      transform.position += (positionChange * Time.deltaTime);
      Debug.Log("Y-Position: " + transform.position.y);

      //Use the conditional to either increment or decrement the y-value
      if (transform.position.y > 65)
      {
        positionChange = new Vector3(0, -1, 0); //move the platform DOWN
      }
      else if (transform.position.y < 55)
      {
        positionChange = new Vector3(0, 1, 0); //move the platform UP
      }
    }
}
