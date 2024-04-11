using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorEnemigoDelante : MonoBehaviour
{
    public bool enemigoDelante;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Enemigo")
        {
            enemigoDelante = true;
        }    
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.tag == "Enemigo")
        {
            enemigoDelante = false;
        }    
    }
}
