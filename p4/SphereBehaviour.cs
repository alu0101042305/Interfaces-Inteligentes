using UnityEngine;

// Cambia el color del material por 1 segundo al producirce el evento CollisionWithSphere
// También dispara el mismo evento cuando se detecta colisión.
public class SphereBehaviour : MonoBehaviour
{
    Renderer rd;
    Color originalColor;

    private void Start()
    {
        rd = GetComponent<Renderer>();
        originalColor = rd.material.color;
        GameController.CollisionWithSphere += OnCollisionWithSphere;
    }

    private void OnDestroy()
    {
        GameController.CollisionWithSphere -= OnCollisionWithSphere;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameController.TriggerCollisionWithSphere();
    }

    void OnCollisionWithSphere()
    {
        rd.material.color = Color.yellow;
        CancelInvoke();
        Invoke("ResetColor", 1);
    }

    void ResetColor()
    {
        rd.material.color = originalColor;
    }

}
