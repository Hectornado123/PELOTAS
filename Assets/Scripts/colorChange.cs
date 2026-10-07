using UnityEngine;

public class colorChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {

        GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnTriggerExit(Collider other)
    {

        GetComponent<Renderer>().material.color = Color.blue;
    }
}
