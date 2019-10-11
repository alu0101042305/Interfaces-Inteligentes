using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XZMove : MonoBehaviour
{
    public float speed = 1;
    public float giro = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0,
                                Input.GetAxis("Vertical") * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * giro);
    }
}
