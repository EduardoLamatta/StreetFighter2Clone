using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RangoGolpe : MonoBehaviour
{
    [HideInInspector] public bool rangoGolpe;
    [SerializeField] private float ataqueRandom;
    public Acciones acciones;
    public PuñosNormalesBot ataquePuños;
    public PatadasNormalesBot ataquePatadas;

    public PatadasAgachado patadasAgachado;
    public PatadasSaltar patadasSaltar;
    public PuñosAgachado puñosAgachado;
    public PuñosSaltar puñosSaltar;
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

            AtaquesBotPuños();
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

    private void AtaquesBotPuños()
    {
        if (ataqueRandom < 20)
        {
            if (acciones.agachado)
            {
                puñosAgachado.PuñosLigero();
            }
            else if (!acciones.enPiso)
            {
                puñosSaltar.PuñosLigero();
            }
            else ataquePuños.PuñoLigeroBot();
        }
        else if (ataqueRandom > 20 && ataqueRandom < 40)
        {
            if (acciones.agachado) puñosAgachado.PuñosMedio();

            else if (!acciones.enPiso) puñosSaltar.PuñosMedio();

            else ataquePuños.PuñoMedioBot();
        }
        else if (ataqueRandom > 40 && ataqueRandom < 60)
        {
            if (acciones.agachado) puñosAgachado.PuñosFuerte();

            else if (!acciones.enPiso) puñosSaltar.PuñosFuerte();

            else ataquePuños.PuñoFuerteBot();
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
