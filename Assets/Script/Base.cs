using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    public int da�o = 20;
    public Slider vidaBase;
    public Contador ContadorTiempo;
    public GameObject Perdedor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //El value se tiene que cambiar tambi�n en el slider de unity para que se aplique el da�o
        vidaBase.GetComponent<Slider>().value = da�o;
        if (vidaBase.GetComponent<Slider>().value == 0)
        {
            ContadorTiempo.PauseGame();
            Perdedor.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            Debug.Log(gameObject.name);
            da�o = da�o - 5;
        }
    }

}
