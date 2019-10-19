using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cuenta el número de colisiones con el objeto llamado Ethan
public class CollisionCount : MonoBehaviour
{
    static int count = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ethan")
        {
            print("El número de colisiones es: " + (++count));
        }
    }

}
