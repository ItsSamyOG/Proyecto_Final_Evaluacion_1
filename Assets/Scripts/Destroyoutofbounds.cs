using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyoutofbounds : MonoBehaviour
{
    public class DestroyOutOfBounds : MonoBehaviour
    {
        private float upperLim = 230f;
        private float lowerLim = -20f;

        void Update()
        {
            // Proyectil fallida
            if (transform.position.z > upperLim)
            {
                Destroy(gameObject);
            }

            if (transform.position.z < lowerLim)
            {
                Destroy(gameObject);
                Time.timeScale = 0;
            }

        }
    }
}
