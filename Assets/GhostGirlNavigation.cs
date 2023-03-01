using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostGirlNavigation : MonoBehaviour
{
    public Transform playerTransform;

    private NavMeshAgent navAgent;

    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        navAgent.destination = playerTransform.position;
    }
}

