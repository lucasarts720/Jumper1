using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutoSalto : MonoBehaviour
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
            tuto.text = "Salta a la otra plataforma con la tecla ESPACIO";
        }
    }
}
