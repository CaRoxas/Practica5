using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Vector3 comienzo;
    public GameObject bixo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // han pasado X seg?
        int posx = Random.Range(470, 590);
        //La posx es el rango que le damos nosotras (que vaya de, en nuestro caso, 497 a 582)
        //El 50 es la posición de Z pero sin ningún rango sino en línea recta (si quisieramos un rango tendríamos que hacer como el posx pero en Z) 
        comienzo = new Vector3(posx, 0, 50);
        Debug.Log(comienzo);
        GameObject bloqueXana = GameObject.Instantiate(bixo, comienzo, Quaternion.identity);
    }
}
