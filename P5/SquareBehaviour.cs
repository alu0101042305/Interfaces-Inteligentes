using UnityEngine;

// Dispara el evento CollisionWithSquare al detectar colisión.
public class SquareBehaviour : MonoBehaviour
{

    Renderer rd;
    int collisionCount = -1;

    private void Start()
    {
        rd = GetComponent<Renderer>();
        GameController.B += OnDisparoB;
    }

    private void OnDestroy()
    {
        GameController.B -= OnDisparoB;
    }

    private void OnDisparoB()
    {
        if (collisionCount >= 1)
        {
            rd.material.color = new Color(
              Random.Range(0f, 1f),
              Random.Range(0f, 1f),
              Random.Range(0f, 1f)
            );
            GameController.money++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
    }

    private void OnCollisionExit(Collision collision)
    {
        collisionCount--;
    }

}
