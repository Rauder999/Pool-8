using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiyController : MonoBehaviour
{
    public Player _player;
    public Rigidbody player_rb;
    public SpriteRenderer kiy;
    
    public void ChangeKiyPosition()
    {
        transform.position = _player.transform.position;
    }

    public void Deactivate()
    {
       
        if (player_rb.GetComponent<Rigidbody>().velocity.magnitude == 0)
        {
            kiy.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            kiy.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    




    void Start()
    {
        ChangeKiyPosition();
    }

    
    void Update()
    {
        Deactivate();
    }
}
