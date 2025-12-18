using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocandoElSuelo : MonoBehaviour
{
    public SaltaCamaradaStalin Stalin;
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.gameObject.name == "Stalin")
        {
            Stalin.is_jumping = false;
            Stalin.jumps = 0;
        }            
        
    }
}
