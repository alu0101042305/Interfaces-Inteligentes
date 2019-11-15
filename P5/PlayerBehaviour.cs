using UnityEngine;

// Incrementa o decrementa el atributo poder según se produzcan los eventos
// CollisionWithSquare o CollisionWithSphere respectivamente.
public class PlayerBehaviour : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("B")) {
            foreach (GameObject cylinder in GameObject.FindGameObjectsWithTag("C"))
            {
                cylinder.transform.Translate(Vector3.one * 0.1f * cylinder.GetComponent<CylinderBehabiour>().poder);
            }
        }
    }
}
