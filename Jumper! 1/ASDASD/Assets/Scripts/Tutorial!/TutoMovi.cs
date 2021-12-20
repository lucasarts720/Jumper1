using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutoMovi : MonoBehaviour
{

    public Text tuto;

    void Start()
    {
        tuto.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            tuto.text = "Avanza a la plataforma AMARILLA con las TECLAS W/A/S/D";
        }
    }
}
