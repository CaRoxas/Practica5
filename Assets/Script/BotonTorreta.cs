using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonTorreta : MonoBehaviour
{
    public GameObject arma;
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
            BotoncitoTorreta();
        }
    }
    public void BotonOn()
    {
        if (activado == false)
        {
            activado = true;
        }
    }
    public void BotoncitoTorreta()
    {
        if (Input.GetMouseButtonDown(0) && billetera.dinero >= 30)
        {
            Ray lugarpointed = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit torretita;
            int mascara = LayerMask.GetMask("Terrain");
            if(Physics.Raycast(lugarpointed, out torretita, Mathf.Infinity, mascara))
            {
                if (torretita.collider.gameObject.tag == "Suelo")
                {
                    GameObject.Instantiate(arma, torretita.point, Quaternion.identity);
                    billetera.quitarDineroTorreta();
                }
            }
        }
    }
}
