using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Enemigo : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform premio;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = premio.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
