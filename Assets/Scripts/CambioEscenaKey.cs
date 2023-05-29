using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenaKey : MonoBehaviour
{
    void Update(){
        if (!GameObject.FindGameObjectWithTag("Key")){
        SceneManager.LoadScene("Menu Ganaste");
        }
    }
}
