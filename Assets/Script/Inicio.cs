using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    public GameObject Iniciar;
    public Contador tiempillo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Iniciar != null)
        {
            tiempillo.PauseGame();
        }

    }
    public void BotonInicio()
    {
        Iniciar.SetActive(false);
        tiempillo.Restart();
    }
}
