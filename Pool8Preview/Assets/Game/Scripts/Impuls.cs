using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impuls : MonoBehaviour
{
    Vector3 direction;
    public float acceleration;
    public Rigidbody rb;


    void GiveImpuls()
    {

        if (Input.GetMouseButtonDown(0))
        {
            direction = Camera.main.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, 0, Input.mousePosition.z));

            rb.AddForce(direction * acceleration, ForceMode.Impulse);
        }
    }
    

     
    void Start()
    {
        
    }

     
    void FixedUpdate()
    {
        GiveImpuls();
    }
}
