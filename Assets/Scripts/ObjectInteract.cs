using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    public Inventario inventario;   

    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }

    private void OnTriggerEnter (Collider other){
        if (other.tag == " Player"){
            Destroy(gameObject);
            inventario.Cantidad = inventario.Cantidad + 1;
        }
        
    }
}
