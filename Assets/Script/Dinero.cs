using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Dinero : MonoBehaviour
{
    public TMP_Text textoDinero;

    public int dinero = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textoDinero.text = "X" + dinero;
    }

    public void quitarDineroTorreta()
    {
        dinero = dinero - 30;
    }
    public void quitarDineroValla()
    {
        dinero = dinero - 10;
    }
}
