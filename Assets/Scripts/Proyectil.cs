using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speed = 40f;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Desplazarte hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
