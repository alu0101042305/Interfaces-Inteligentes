using UnityEngine;

// Incrementa o decrementa el atributo poder según se produzcan los eventos
// CollisionWithSquare o CollisionWithSphere respectivamente.
public class PlayerBehaviour : MonoBehaviour
{
    int poder = 0;
    void Start()
    {
        GameController.CollisionWithSphere += decreasePower;
        GameController.CollisionWithSquare += increasePower;
    }

    private void OnDestroy()
    {
        GameController.CollisionWithSphere -= decreasePower;
        GameController.CollisionWithSquare -= increasePower;
    }

    void increasePower()
    {
        print("El poder actual es " + ++poder);
    }

    void decreasePower()
    {
        print("El poder actual es " + --poder);
    }
}
