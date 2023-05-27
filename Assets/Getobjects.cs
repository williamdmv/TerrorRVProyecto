using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getobjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Destroy(other.gameObject);                  
        }
    }
}
