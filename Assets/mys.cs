using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mys : MonoBehaviour
{
    public Transform target; //El objetivo que queremos seguir
    public float speed = 5f; //La velocidad de movimiento del personaje
    public float distanceToGround = 1.5f; //La distancia desde el centro del personaje al suelo

    void Update()
    {
        //Verificamos si el objetivo existe
        if (target != null)
        {
            //Calculamos la dirección hacia el objetivo
            Vector3 direction = target.position - transform.position;

            //Normalizamos la dirección para obtener solo la dirección de movimiento
            Vector3 movement = direction.normalized;

            //Calculamos la distancia actual al objetivo
            float distance = direction.magnitude;

            //Verificamos si estamos lo suficientemente cerca del objetivo
            if (distance < distanceToGround)
            {
                //Si estamos lo suficientemente cerca, detenemos el movimiento
                movement = Vector3.zero;
            }

            //Lanzamos un rayo hacia abajo para detectar la superficie debajo del personaje
            RaycastHit hit;
            if (Physics.Raycast(transform.position, -Vector3.up, out hit, distanceToGround))
            {
                //Ajustamos la posición del personaje para que esté sobre la superficie
                transform.position = hit.point + Vector3.up * distanceToGround;
            }

            //Movemos al personaje hacia el objetivo
            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
    }

}
