using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutoMuerte: MonoBehaviour
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
            tuto.text = "Si caes al suelo, PERDERAS";
        }
    }
}