using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ds4 : MonoBehaviour
{
    public float mouseSensitivity = 80f;
    public Transform playerBody;

    private Vector2 rotateInput; // Input de rotaci�n del joystick R3

    private float xRotation = 0f;

    void Update()
    {
        // Obtener el input del joystick R3
        rotateInput = Gamepad.current.rightStick.ReadValue() * mouseSensitivity * Time.deltaTime;

        // Actualizar la rotaci�n en el eje X
        xRotation -= rotateInput.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Aplicar la rotaci�n a la c�mara
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotar el cuerpo del jugador en el eje Y
        playerBody.Rotate(Vector3.up, rotateInput.x);
    }
}
