using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Añade en cada FixedUpdate una fuerza con dirección aleatoria
 */
public class RandomMovement : MonoBehaviour
{
    public float speed = 1F;
    Rigidbody rb;
    Vector3 dir;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        dir.x = Random.Range(-1F, 1F);
        dir.z = Random.Range(-1F, 1F);
        rb.AddForce(dir * speed);
    }
}
