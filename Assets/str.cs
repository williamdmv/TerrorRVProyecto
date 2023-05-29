using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class str : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo")
        {
            SceneManager.LoadScene("Menu de inicio");
        }
    }


}
