using UnityEngine;

public class condicionales : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int vida = 100;
    void Start()
    {
      
        double velocidad = 10;

        Debug.Log("la velocidad es " + velocidad);

    }
void Update()
    {


        if (vida == 0)
        {
            Debug.Log("tas muerto");
        }
        else
        {

            Debug.Log("tas vivo");
        }
    }
  
}
