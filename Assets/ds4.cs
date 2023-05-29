using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class ds4 : MonoBehaviour
{
    public float mouseSensitivity = 80f;
    public Transform playerBody;

    private Vector2 rotateInput; // Input de rotación del joystick R3
    private bool xButtonClicked = false; // Variable para detectar el clic del botón "X"
    private int nombreEscena = 1;
    private float xRotation = 0f;

    void Update()
    {
        if (Gamepad.current != null)
        {
            // Obtener el input del joystick R3
            rotateInput = Gamepad.current.rightStick.ReadValue() * mouseSensitivity * Time.deltaTime;

            // Actualizar la rotación en el eje X
            xRotation -= rotateInput.y;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            // Aplicar la rotación a la cámara
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            // Rotar el cuerpo del jugador en el eje Y
            playerBody.Rotate(Vector3.up, rotateInput.x);

            // Detectar el clic del botón "X"
            if (Gamepad.current.xButton.wasPressedThisFrame)
            {
                xButtonClicked = true;
            }
        }
        else
        {
            // Manejar el caso en el que no se detecte ningún gamepad
            // por ejemplo, asignando un valor predeterminado a rotateInput.
            rotateInput = Vector2.zero;
        }
    }

    public void LateUpdate()
    {
        // Realizar acciones específicas cuando se hace clic en el botón "X"
        if (xButtonClicked)
        {
            SceneManager.LoadScene(nombreEscena);
            // Agrega aquí tu código para ejecutar acciones cuando se hace clic en el botón "X"
            // Por ejemplo:
            Debug.Log("Botón 'X' presionado");

            // Reiniciar la variable xButtonClicked a false para evitar repetición continua de acciones
            xButtonClicked = false;
        }
    }
}