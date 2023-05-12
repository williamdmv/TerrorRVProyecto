using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
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
        // Movimiento horizontal
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 moveHorizontal = transform.right * horizontal * speed;

        // Movimiento vertical
        float vertical = Input.GetAxis("Vertical");
        Vector3 moveVertical = transform.forward * vertical * speed;

        // Movimiento total
        Vector3 move = moveHorizontal + moveVertical;

        // Aplicar movimiento al CharacterController
        controller.Move(move * Time.deltaTime);

        // Aplicar gravedad
        if (controller.isGrounded) // Si el personaje está en el suelo
        {
            moveDirection = Vector3.zero; // Reiniciamos la dirección del movimiento
        }
        moveDirection.y -= gravity * Time.deltaTime; // Aplicamos la gravedad
        controller.Move(moveDirection * Time.deltaTime); // Aplicamos el movimiento en la dirección calculada
    }
}
