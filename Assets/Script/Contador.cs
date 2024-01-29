using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Contador : MonoBehaviour
{
    public TMP_Text texto;
    float tiempo = 300f;
    int minutos, segundos;
    public GameObject valla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = tiempo - Time.deltaTime;
        minutos = (int)(tiempo / 60f);
        segundos = (int)(tiempo - minutos * 60f);
        texto.text = string.Format("{0}:{1}", minutos, segundos);
    }
    public void desaparecerValla()
    {
        if (tiempo == 10f)
        {
            Destroy(valla);
        }
    }
}
