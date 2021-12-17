using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 40f;
    private float horizontalInput;
    private float verticalInput;
    private float xRange = 200f;
    private float yMax = 200f;
    private float yMin = 0f;
    private float zRange = 200f;
    public GameObject ProyectilPrefab;
    public int counter = 10;
    private int totalmoneda = 0;
    private int Maxmoneda = 10;




    // Start is called before the first frame update
    void Start()
    {
         transform.position = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        // Desplazarte hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // El eje “Horizontal” rotas sobre el eje Y
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        
        // El eje “Vertical” rotas sobre el eje X
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * verticalInput);

        // Límite de pantalla derecho
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,
                transform.position.z);
        }

        // Límite de pantalla izquierdo
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,
                transform.position.z);
        }
        
        // Límite de pantalla arria
        if (transform.position.y > yMax)
        {
            transform.position = new Vector3(transform.position.x, yMax,
                transform.position.z);
        }

        // Límite de pantalla abajo
        if (transform.position.y < yMin)
        {
            transform.position = new Vector3(transform.position.x, yMin,
                transform.position.z);
        }
        // Límite de pantalla eje z
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
               zRange);
        }

        // Límite de pantalla eje z
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
               -zRange);
        }
        
        // Disparo
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(ProyectilPrefab, transform.position,
                transform.rotation);
        }
    }

    private void OnTriggerEnter (Collider otherCollision)
    {
        if (otherCollision.gameObject.CompareTag("Moneda"))
        {
            Destroy(otherCollision.gameObject);

            totalmoneda++;
            if (totalmoneda >= Maxmoneda)
            {
                Debug.Log("Has consefuido las 10 monedas, juego completado");
                Time.timeScale = 0f;
            }
           
        }
        
        if (otherCollision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0f;
        }
        
    }


}
