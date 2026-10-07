using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("te quemas");
        SceneManager.LoadScene("inputs");
    }
}
