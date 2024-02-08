using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class Torretas : MonoBehaviour
{
    public GameObject municion;
    public int radio = 8;
    public int velocidad;
    Vector3 cañon;
    float tiempo = 0f;
    public float fuerza = 250f;
    // Start is called before the first frame update
    void Start()
    {
        cañon = this.GetComponentInChildren<Transform>().position;
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
                // transform.LookAt(enemigo.transform.position);
                Vector3 relativePos = enemigo.transform.position - transform.position;
                Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
                transform.rotation = rotation;

                GameObject municionClon = GameObject.Instantiate(municion, cañon, Quaternion.identity);
                municionClon.GetComponent<Rigidbody>().AddForce(relativePos * fuerza, ForceMode.Impulse);

                tiempo = 0.5f;
            }
        }
        else
        {
            tiempo = tiempo - Time.deltaTime;
        }
        /*/if (tiempo == 2f)
        {
            Destroy(gameObject);
        }*/
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radio);
        Gizmos.color = Color.yellow;    
        Gizmos.DrawRay(new Ray(transform.position,cañon  * 100));
    }
}
