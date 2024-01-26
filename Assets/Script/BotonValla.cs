using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonValla : MonoBehaviour
{
    public GameObject defensa;
    bool activado = false;

    public Dinero billetera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activado == true)
        {
            BotoncitoValla();
        }
    }
    public void BotonEncendido()
    {
        if (activado == false)
        {
            activado = true;
        }
    }
    public void BotoncitoValla()
    {
        if (Input.GetMouseButtonDown(0) && billetera.dinero >= 10)
        {
            Ray sitio = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit vallita;
            int mascara = LayerMask.GetMask("Terrain");
            if (Physics.Raycast(sitio, out vallita, Mathf.Infinity, mascara))
            {
                if (vallita.collider.gameObject.tag == "Suelo")
                {
                    GameObject.Instantiate(defensa, vallita.point, Quaternion.identity);
                    billetera.quitarDineroValla();
                }
            }
        }
    }
}
