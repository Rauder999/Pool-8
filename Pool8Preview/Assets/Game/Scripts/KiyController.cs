using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiyController : MonoBehaviour
{
    public Player _player;
    public void ChangeKiyPosition()
    {
        transform.position = _player.transform.position;
    }

    void Start()
    {
        ChangeKiyPosition();
    }

    
    void Update()
    {
        
    }
}
