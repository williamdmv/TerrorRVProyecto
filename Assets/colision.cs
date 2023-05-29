using UnityEngine;
using UnityEngine.SceneManagement;

public class colision : MonoBehaviour
{
    public string sceneName = "Menu de inicio"; // Nombre de la escena a la que deseas cambiar
    
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(sceneName);
            }
        }

    
}



