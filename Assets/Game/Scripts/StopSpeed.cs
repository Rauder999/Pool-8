using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSpeed : MonoBehaviour
{

    public float minSpeed;
    private float speed;
    
  public void Stop()
    {
        speed = GetComponent<Rigidbody>().velocity.magnitude;

        if  (speed < minSpeed)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().freezeRotation= true;
            GetComponent<Rigidbody>().freezeRotation = false;
        }
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        Stop();
    }
}
