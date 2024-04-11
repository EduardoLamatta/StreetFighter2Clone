using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorJugadorDelante : MonoBehaviour
{
    public bool jugadorDelante;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            jugadorDelante = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            jugadorDelante = false;
        }
    }
}
