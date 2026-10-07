using UnityEngine;

public class vidas : MonoBehaviour
{

    public string nombre = "Hector";
    public int vida = 100;
    public double velocidad = 5.5;
    public object caja;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(nombre);
        Debug.Log(vida);
        Debug.Log(velocidad);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
