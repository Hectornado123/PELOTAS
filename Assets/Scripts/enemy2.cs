using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy2 : MonoBehaviour
{
    float velocidad = 2;

    void Update()
    {


        if (transform.position.z > 3.88f)
        {

            velocidad = -velocidad;
        }

        if (transform.position.z < -2.78f)
        {

            velocidad = -velocidad;
        }
        transform.Translate(0, 0, velocidad * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("te quemas");
        SceneManager.LoadScene("inputs");
    }
}
