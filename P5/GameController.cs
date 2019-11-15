using UnityEngine;
using UnityEngine.UI;

// Controllador de la escena con los eventos de la misma.
public class GameController : MonoBehaviour
{
    public delegate void method();
    public static GameController controller;
    public static event method A;
    public static event method B;
    public static int energy = 1;
    public static int money = 0;

    Text moneyText;
    Text energyText;

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

    void Start() {
        moneyText = GameObject.Find("moneyText").GetComponent<Text>();
        energyText = GameObject.Find("energyText").GetComponent<Text>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) {
            A();
        }
        else if (Input.GetKeyDown(KeyCode.B)) {
            B();
        }
        moneyText.text = "Dinero " + money;
        energyText.text = "Energía " + energy;
    }

    public void AddEnergy() {
        if (money > 0) {
            money--;
            energy++;
        }
    }

}
