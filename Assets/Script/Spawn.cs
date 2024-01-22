using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Vector3 comienzo;
    public GameObject bixo;
    bool transcurso;
    float tiempo = 15f;
    // Start is called before the first frame update
    void Start()
    {
        transcurso = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transcurso == false)
        {
            CargarBixo();
        }
        else
        {
            if (tiempo > 0)
            {
                tiempo = tiempo - Time.deltaTime;
            }
            else
            {
                transcurso = false;
            }
        }
       
    }
    void CargarBixo()
    {
        int posx = Random.Range(470, 590);
        //La posx es el rango que le damos nosotras (que vaya de, en nuestro caso, 497 a 582)
        //El 50 es la posición de Z pero sin ningún rango sino en línea recta (si quisieramos un rango tendríamos que hacer como el posx pero en Z) 
        comienzo = new Vector3(posx, 0, 50);
        GameObject bloqueXana = GameObject.Instantiate(bixo, comienzo, Quaternion.identity);
        tiempo = 2f;
        transcurso = true;
        
    }
}
