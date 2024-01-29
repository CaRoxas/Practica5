using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valla : MonoBehaviour
{
    float tiempo = 0f;
    // Start is called before the first frame update
    void Start()
    {
        tiempo = tiempo + Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = tiempo + Time.deltaTime;
        if (tiempo >= 10f)
        {
            Destroy(gameObject);
        }
    }
}
