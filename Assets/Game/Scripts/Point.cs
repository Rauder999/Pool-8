using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public Player player;
    
    public CameraScoreCount cameraScoreCount;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>()) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        cameraScoreCount.ScoreCounting();
        Destroy(other.gameObject);
        
       

        
    }

    void Start()
    {
       
    }

    void Update()
    {
        
    }
}
