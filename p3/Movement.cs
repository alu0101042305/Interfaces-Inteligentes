using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Implementa el movimiento de un objeto con Rigidbody
 */
public class Movement : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    Vector3 dir;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        rb.velocity = dir * speed;
    }

}
