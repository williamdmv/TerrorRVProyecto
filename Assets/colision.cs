using UnityEngine;
using UnityEngine.SceneManagement;

public class colision : MonoBehaviour
{
    public string sceneName;
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    
}



