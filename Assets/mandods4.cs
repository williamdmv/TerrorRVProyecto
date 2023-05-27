using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class mandods4 : MonoBehaviour
{
    public float speed = 6.0f; // Velocidad del jugador
    public float gravity = 9.8f; // Gravedad del jugador

    private CharacterController controller; // Referencia al CharacterController
    private Vector3 moveDirection = Vector3.zero; // Dirección del movimiento

    private void Start()
    {
        controller = GetComponent<CharacterController>(); // Obtenemos la referencia al CharacterController
    }

    private void Update()
    {
        // Obtener el input del joystick L3
        Vector2 moveInput = new Vector2(
            Gamepad.current.leftStick.x.ReadValue(),
            Gamepad.current.leftStick.y.ReadValue()
        );

        // Calcular la dirección del movimiento
        Vector3 moveDirection = new Vector3(moveInput.x, 0f, moveInput.y);
        moveDirection.Normalize();

        // Transformar la dirección del movimiento al espacio del jugador
        moveDirection = transform.TransformDirection(moveDirection);

        // Aplicar velocidad al movimiento
        moveDirection *= speed;

        // Aplicar movimiento al CharacterController
        controller.Move(moveDirection * Time.deltaTime);

        // Aplicar gravedad
        if (controller.isGrounded) // Si el personaje está en el suelo
        {
            moveDirection.y = 0f; // Reiniciamos la dirección vertical del movimiento
        }
        moveDirection.y -= gravity * Time.deltaTime; // Aplicamos la gravedad
        controller.Move(moveDirection * Time.deltaTime); // Aplicamos el movimiento en la dirección calculada
    }
}
