using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    private float minDistancia = 1;
    private float maxDistancia = 2;
    private float suavidad = 10;
    private float distancia;
    Vector3 direccion;
    void Start()
    {
        direccion = transform.localPosition.normalized;
        distancia = transform.localPosition.magnitude;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posDecamara = transform.parent.TransformPoint(direccion * maxDistancia);

        RaycastHit hit;
        if (Physics.Linecast(transform.parent.position, posDecamara, out hit)) 
        {
            distancia = Mathf.Clamp(hit.distance * 0.85f, minDistancia, maxDistancia);

        }
        else
        {
            distancia = maxDistancia;

        }
        transform.localPosition = Vector3.Lerp(transform.localPosition,distancia * direccion, suavidad * Time.deltaTime);
    }
}
