using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class ControlJugador : MonoBehaviour
{
    private Rigidbody rb;
    public int rapidez;
    public Text textoCantidadRecolectados;
    private int cont;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cont = 0;
        ColectarOro();
    }

    private void ColectarOro()
    {
        textoCantidadRecolectados.text = "Cantidad recolectados: " + cont.ToString();
        if (cont >= 5)
        {
            SceneManager.LoadScene("Ganar", LoadSceneMode.Single);
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.position += rb.transform.forward * rapidez * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.position += rb.transform.right * rapidez * -1f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.position += rb.transform.forward * rapidez * -1f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.position += rb.transform.right * rapidez * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coleccionable") == true)
        {
            cont = cont + 1;
            ColectarOro();
            other.gameObject.SetActive(false);
        }
    }
}