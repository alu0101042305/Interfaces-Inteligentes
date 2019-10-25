using System.Collections;
using UnityEngine;
// Deshabilita (o habilita) el componente Light al pulsar la tecla L.
public class LightController : MonoBehaviour
{
    new Light light;

    private void Start()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            light.enabled = !light.enabled;
        }
    }

}
