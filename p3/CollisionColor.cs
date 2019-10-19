using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Cambia el color del objeto según los eventos de colisión.
 */
public class CollisionColor : MonoBehaviour
{
    Renderer rd;

    private void Start()
    {
        rd = GetComponent<Renderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.green;
    }

    private void OnCollisionStay(Collision collision)
    {
        rd.material.color = Color.blue;
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = Color.red;
    }
}
