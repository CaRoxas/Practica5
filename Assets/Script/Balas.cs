using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    float tiempo = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo == 3f)
        {
            Destroy(gameObject);
        }
    }
}
