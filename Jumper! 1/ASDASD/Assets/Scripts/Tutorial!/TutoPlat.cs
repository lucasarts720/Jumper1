using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TutoPlat : MonoBehaviour
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
            tuto.text = "Tienes que moverte JUNTO con la plataforma! Sino te caeras";
        }
    }
}
