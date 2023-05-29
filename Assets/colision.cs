using UnityEngine;
using UnityEngine.SceneManagement;

public class colision : MonoBehaviour
{
<<<<<<< HEAD
    // Nombre de la escena a la que deseas cambiar
=======
    public string sceneName; // Nombre de la escena a la que deseas cambiar
>>>>>>> 667a9f230dbc946f61696ffc7d7b07fb0910752f
    
         void OnCollisionEnter(Collision other)
        {
<<<<<<< HEAD
            
                SceneManager.LoadScene(0);
            
=======
            if (collision.gameObject.CompareTag("Enemigo"))
            {
                SceneManager.LoadScene(sceneName);
            }
>>>>>>> 667a9f230dbc946f61696ffc7d7b07fb0910752f
        }

    
}



