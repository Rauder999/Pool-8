using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Point : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>()) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        Destroy(other.gameObject);
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
