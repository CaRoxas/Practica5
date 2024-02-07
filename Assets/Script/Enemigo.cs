using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Enemigo : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform premio;
    public GameObject balas;
    Rigidbody rb;
    public int vida = 2;
    public Dinero billetera;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        premio = GameObject.Find("Base").transform;
        billetera = GameObject.Find("Billetera").GetComponent<Dinero>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = premio.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Balas")
        {
            vida = vida - 1;
            billetera.añadirDinero();
            Destroy(collision.gameObject);
            if (vida == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
