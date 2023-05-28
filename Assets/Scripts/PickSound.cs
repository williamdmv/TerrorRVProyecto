using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSound : MonoBehaviour
{
    public AudioSource quienEmite;
    public AudioClip elSonido;
    public float volumen = 1f;

    private void OnTriggerEnter(Collider other){
        quienEmite.PlayOneShot(elSonido, volumen);

    }
}
