using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torretas : MonoBehaviour
{
    public GameObject municion;
    public int radio = 5;
    public int velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] listaChoques;
        listaChoques = Physics.OverlapSphere(this.transform.position, radio);
        foreach (Collider enemigo in listaChoques)
        {
            transform.LookAt(enemigo.transform.position);
            // instanciar la bala en el punto de tiro
            Vector3 cañon = new Vector3 (0, 1, 1);
            GameObject.Instantiate(municion, cañon, Quaternion.identity);
            // addForce Vectgor3.forward




            // a dicha bala aplicarle una fuerza, hacia donde este el enemigo
            enemigo.gameObject.GetComponent<Rigidbody>();
        }

    }
}
