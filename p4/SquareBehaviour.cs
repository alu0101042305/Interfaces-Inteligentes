using UnityEngine;

// Dispara el evento CollisionWithSquare al detectar colisión.
public class SquareBehaviour : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        GameController.TriggerCollisionWithSquare();
    }

}
