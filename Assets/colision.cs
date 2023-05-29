using UnityEngine;
using UnityEngine.SceneManagement;

public class colision : MonoBehaviour
{
    public string sceneName; // Nombre de la escena a la que deseas cambiar
    
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemigo"))
            {
                SceneManager.LoadScene(sceneName);
            }
        }

    
}



