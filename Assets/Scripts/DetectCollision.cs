using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    private void OnTriggerEnter(Collider otherCollider)
    {

        if (gameObject.CompareTag("Proyectil") && otherCollider.gameObject.CompareTag("Obstacle"))
        {
            // Destruyo la moneda
            Destroy(gameObject);

            // Destruyo la moneda contra el que colisiono
            Destroy(otherCollider.gameObject);  
        }
    }
}
