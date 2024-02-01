using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Torretas : MonoBehaviour
{
    public GameObject municion;
    public int radio = 8;
    public int velocidad;
    Vector3 cañon;
    float tiempo = 0f;
    public float fuerza = 100f;
    // Start is called before the first frame update
    void Start()
    {
        cañon = this.GetComponentInChildren<Transform>().position;
        Debug.Log(cañon);
    }

    // Update is called once per frame
    void Update()
    {
        if(tiempo <= 0)
        {
            Collider[] listaChoques;
        listaChoques = Physics.OverlapSphere(this.transform.position, radio, 1 << 3);
         Debug.Log(listaChoques.Length);
        foreach (Collider enemigo in listaChoques)
        {
                Debug.Log(enemigo.gameObject.name);
           // transform.LookAt(enemigo.transform.position);
            // TODO: ROTAR EN EL EJE Z

            GameObject municionClon = GameObject.Instantiate(municion, cañon, Quaternion.identity);
            // addForce Vector3.forward


            // a dicha bala aplicarle una fuerza, hacia donde este el enemigo
            municionClon.GetComponent<Rigidbody>().AddForce(Vector3.forward * fuerza, ForceMode.Acceleration);

            tiempo = 1f;

            // ver cuantas balas se han disparado
        }
        }
        else
        {
            tiempo = tiempo - Time.deltaTime;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radio);
    }
}
