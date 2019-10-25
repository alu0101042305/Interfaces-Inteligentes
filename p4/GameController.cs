using UnityEngine;

// Controllador de la escena con los eventos de la misma.
public class GameController : MonoBehaviour
{
    public delegate void method();
    public static GameController controller;
    public static event method CollisionWithSquare;
    public static event method CollisionWithSphere;

    void Awake()
    {
        if(controller == null)
        {
            controller = this;
        } else if(controller != this)
        {
            Destroy(gameObject);
        }
    }

    public static void TriggerCollisionWithSphere()
    {
        CollisionWithSphere();
    }

    public static void TriggerCollisionWithSquare()
    {
        CollisionWithSquare();
    }

}
