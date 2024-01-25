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
    public int vida = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        premio = GameObject.Find("Base").transform;
        // GameObject premioObjeto = GameObject.Find("Base")
        // premio = premoiObjeto.transform

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
            Destroy(collision.gameObject);
            Debug.Log(gameObject.tag);
            if (vida == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
