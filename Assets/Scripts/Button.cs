using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DoorToDestroy;

    private void OnTriggerEnter(Collider other)
    {
        Destroy (DoorToDestroy);
        Debug.Log("qupic");
    }
}
