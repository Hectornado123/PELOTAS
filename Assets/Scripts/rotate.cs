using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rotate : MonoBehaviour
{

    public float velocidad = 0.5f;
    public TMP_Text textoUI;
    public int monedas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(velocidad, 0, 0);



    }

    private void OnTriggerEnter(Collider other)
    {

        monedas = Convert.ToInt32(textoUI.text);

       monedas += 1;
        textoUI.text = monedas.ToString();
        Debug.Log(monedas);
        Destroy(gameObject);

        if (monedas == 5){
            SceneManager.LoadScene("inputs");
        }
    }
}
