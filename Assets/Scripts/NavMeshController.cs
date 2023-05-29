using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    private Animator animator;
    private bool pursuing;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        pursuing = true;
        agent.destination = player.position;
    }

    void Update()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Correr", pursuing);

        if (pursuing)
        {
            agent.destination = player.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pursuing = false;
            animator.SetBool("Ataque", true);
            animator.SetBool("Correr", false);
        }
    }
}




