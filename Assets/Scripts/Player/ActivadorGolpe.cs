using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorGolpe : MonoBehaviour
{
    public GameObject activador;
 
    public PatadasAgachado patadasAgachado;

    public PatadasDelanteras patadasDelanteras;

    public PatadasSaltar patadasSaltar;

    public PuñosAgachado puñosAgachado;

    public PuñosDelanteros puñosDelanteros;

    public PuñosSaltar puñosSaltar;

    public VidaEnemigo vidaEnemigo;

    //public VidaJugador vidaJugador;

    [SerializeField] private float dañoPuñoL, dañoPuñoM, dañoPuñoF;

    [SerializeField] private float dañoPatadaL, dañoPatadaM, dañoPatadaF;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Enemigo")
        {
            GolpesNormales();

            /*PuñosAgachado();

            PuñosDelanteras();

            PuñosSaltar();

            PatadasNormales();
            
            PatadasAgachado();

            PatadasSaltar();

            PatadasDelanteras();*/

        }

    }

    private void GolpesNormales()
    {
        if (AtaqueController.instance.GolpeL)
        {
            vidaEnemigo.Daño(dañoPuñoL);
                   
        }

        if (AtaqueController.instance.GolpeM)
        {
            vidaEnemigo.Daño(dañoPuñoM);
        }

        if (AtaqueController.instance.GolpeF)
        {
            vidaEnemigo.Daño(dañoPuñoF);
        }

    }

    /*private void PuñosAgachado()
    {
        if (puñosAgachado.PuñoL == true)
        {
            vidaEnemigo.Daño(dañoPuñoL);
        }

        if (puñosAgachado.PuñoM == true)
        {
            vidaEnemigo.Daño(dañoPuñoM);
        }

        if (puñosAgachado.PuñoF == true)
        {
            vidaEnemigo.Daño(dañoPuñoF);
        }

    }
    private void PuñosDelanteras()
    {
        if (puñosDelanteros.PuñoL == true)
        {
            vidaEnemigo.Daño(dañoPuñoL);
        }

        if (puñosDelanteros.PuñoM == true)
        {
            vidaEnemigo.Daño(dañoPuñoM);
        }

        if (puñosDelanteros.PuñoF == true)
        {
            vidaEnemigo.Daño(dañoPuñoF);
        }

    }


    private void PuñosSaltar()
    {
        if (puñosSaltar.PuñoL == true)
        {
            vidaEnemigo.Daño(dañoPuñoL);
        }

        if (puñosSaltar.PuñoM == true)
        {
            vidaEnemigo.Daño(dañoPuñoM);
        }

        if (puñosSaltar.PuñoF == true)
        {
            vidaEnemigo.Daño(dañoPuñoF);
        }

    }


    private void PatadasNormales()
    {
        if (AtaqueController.instance.GolpeBotL)
        {
            vidaEnemigo.Daño(dañoPatadaL);
        }
        
        if (AtaqueController.instance.GolpeBotM)
        {
            vidaEnemigo.Daño(dañoPatadaM);
        }

        if (AtaqueController.instance.GolpeBotF)
        {
            vidaEnemigo.Daño(dañoPatadaF);
        }

    }

    private void PatadasAgachado()
    {
        if (patadasAgachado.PatadaL == true)
        {
            vidaEnemigo.Daño(dañoPatadaL);
        }
        
        if (patadasAgachado.PatadaM == true)
        {
            vidaEnemigo.Daño(dañoPatadaM);
        }

        if (patadasAgachado.PatadaF == true)
        {
            vidaEnemigo.Daño(dañoPatadaF);
        }
    }

    private void PatadasDelanteras()
    {
        if (patadasDelanteras.PatadaDeL == true)
        {
            vidaEnemigo.Daño(dañoPatadaL);
        }
        
        if (patadasDelanteras.PatadaDeM == true)
        {
            vidaEnemigo.Daño(dañoPatadaM);
        }

        if (patadasDelanteras.PatadaDeF == true)
        {
            vidaEnemigo.Daño(dañoPatadaF);
        }
    }

    private void PatadasSaltar()
    {
        if (patadasSaltar.PatadaL == true)
        {
            vidaEnemigo.Daño(dañoPatadaL);
        }
        
        if (patadasSaltar.PatadaM == true)
        {
            vidaEnemigo.Daño(dañoPatadaM);
        }

        if (patadasSaltar.PatadaF == true)
        {
            vidaEnemigo.Daño(dañoPatadaF);
        }
    }*/
}
