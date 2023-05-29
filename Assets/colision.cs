using UnityEngine;
using UnityEngine.SceneManagement;

public class colision : MonoBehaviour
{
    // Nombre de la escena a la que deseas cambiar
    
         void OnCollisionEnter(Collision other)
        {
            
                SceneManager.LoadScene(0);
            
        }

    
}



