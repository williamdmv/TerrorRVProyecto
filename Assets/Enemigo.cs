using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    public Transform objetivo;
    public float distanciaMinima = 2f;
    public bool correr = false;
    public bool ataque = false;

    private Animator animator;
    private NavMeshAgent navMeshAgent;

    private void Start()
    {
        animator = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (correr)
        {
            if (objetivo != null)
            {
                float distancia = Vector3.Distance(transform.position, objetivo.position);

                if (distancia > distanciaMinima)
                {
                    navMeshAgent.SetDestination(objetivo.position);
                }
                else
                {
                    navMeshAgent.SetDestination(transform.position);
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            correr = false;
            ataque = true;
            animator.SetBool("Ataque", true);
        }
    }

    public void SetCorrer(bool valor)
    {
        correr = valor;
        animator.SetBool("Correr", valor);
    }

    public void SetAtaque(bool valor)
    {
        ataque = valor;
        animator.SetBool("Ataque", valor);
    }
}

