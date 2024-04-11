using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RangoGolpe : MonoBehaviour
{
    [HideInInspector] public bool rangoGolpe;
    [SerializeField] private float ataqueRandom;
    public Acciones acciones;
    public Pu�osNormalesBot ataquePu�os;
    public PatadasNormalesBot ataquePatadas;

    public PatadasAgachado patadasAgachado;
    public PatadasSaltar patadasSaltar;
    public Pu�osAgachado pu�osAgachado;
    public Pu�osSaltar pu�osSaltar;
    public TiempoAtaquesBot tiempoAtaquesbot;
    public VidaJugador vidaJugador;

    private void Update()
    {
        if (rangoGolpe && vidaJugador.cantidadVida >= 0)
        {
            if (!tiempoAtaquesbot.botPuedeAtacar)
            {
                ataqueRandom = Random.Range(1f, 121f);
            }

            AtaquesBotPu�os();
            AtaquesBotPatadas();

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rangoGolpe = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rangoGolpe = false;
        }
    }

    private void AtaquesBotPu�os()
    {
        if (ataqueRandom < 20)
        {
            if (acciones.agachado)
            {
                pu�osAgachado.Pu�osLigero();
            }
            else if (!acciones.enPiso)
            {
                pu�osSaltar.Pu�osLigero();
            }
            else ataquePu�os.Pu�oLigeroBot();
        }
        else if (ataqueRandom > 20 && ataqueRandom < 40)
        {
            if (acciones.agachado) pu�osAgachado.Pu�osMedio();

            else if (!acciones.enPiso) pu�osSaltar.Pu�osMedio();

            else ataquePu�os.Pu�oMedioBot();
        }
        else if (ataqueRandom > 40 && ataqueRandom < 60)
        {
            if (acciones.agachado) pu�osAgachado.Pu�osFuerte();

            else if (!acciones.enPiso) pu�osSaltar.Pu�osFuerte();

            else ataquePu�os.Pu�oFuerteBot();
        }
    }

    private void AtaquesBotPatadas()
    {
        if (ataqueRandom > 60 && ataqueRandom < 80)
        {
            if (acciones.agachado) patadasAgachado.PatadaLigera();

            else if (!acciones.enPiso) patadasSaltar.PatadaLigera();

            else ataquePatadas.PatadaLigeraBot();
        }
        else if (ataqueRandom > 80 && ataqueRandom < 100)
        {
            if (acciones.agachado) patadasAgachado.PatadaMedia();

            else if (!acciones.enPiso) patadasSaltar.PatadaMedia();

            else ataquePatadas.PatadaMediaBot();
        }
        else if (ataqueRandom > 100 && ataqueRandom < 121)
        {
            if (acciones.agachado) patadasAgachado.PatadaFuerte();

            else if (!acciones.enPiso) patadasSaltar.PatadaFuerte();

            else ataquePatadas.PatadaFuerteBot();
        }

    }
}
