using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorGolpeEnemigo : MonoBehaviour
{
    public GameObject activador;

    public PatadasAgachado patadasAgachado;

    public PatadasDelanteras patadasDelanteras;

    public PatadasSaltar patadasSaltar;

    public PuñosAgachado puñosAgachado;

    public PuñosDelanteros puñosDelanteros;

    public PuñosSaltar puñosSaltar;

    public VidaJugador vidaJugador;

    [SerializeField] private float dañoPuñoL, dañoPuñoM, dañoPuñoF;

    [SerializeField] private float dañoPatadaL, dañoPatadaM, dañoPatadaF;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            PuñosNormalesJugador();

            //PatadasNormalesJugador();
        }
    }

    private void PuñosNormalesJugador()
    {
        if (AtaqueController.instance.GolpeBotL)
        {
            vidaJugador.Daño(dañoPuñoL);

        }

        if (AtaqueController.instance.GolpeBotM)
        {
            vidaJugador.Daño(dañoPuñoM);
        }

        if (AtaqueController.instance.GolpeBotF)
        {
            vidaJugador.Daño(dañoPuñoF);
        }
    }

    private void PatadasNormalesJugador()
    {
        if (AtaqueController.instance.GolpeBotL)
        {
            vidaJugador.Daño(dañoPatadaL);

        }

        if (AtaqueController.instance.GolpeBotM)
        {
            vidaJugador.Daño(dañoPatadaM);
        }

        if (AtaqueController.instance.GolpeBotF)
        {
            vidaJugador.Daño(dañoPatadaF);
        }
    }
}
