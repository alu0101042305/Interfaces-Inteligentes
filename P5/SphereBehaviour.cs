using UnityEngine;

// Cambia el color del material por 1 segundo al producirce el evento CollisionWithSphere
// También dispara el mismo evento cuando se detecta colisión.
public class SphereBehaviour : MonoBehaviour
{
    Renderer rd;
    int collisionCount = 0;
    float poder = 0;

    private void Start()
    {
        rd = GetComponent<Renderer>();
        GameController.A += OnDisparoA;
    }

    private void OnDestroy()
    {
        GameController.A -= OnDisparoA;
    }

    private void OnDisparoA() {
        if (collisionCount >= 1) {
            transform.localScale *= 0.9f * (1f / GameController.energy);
            poder *= 0.9f * (1f / GameController.energy);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
    }

    private void OnCollisionExit(Collision collision) {
        collisionCount--;
    }
}
