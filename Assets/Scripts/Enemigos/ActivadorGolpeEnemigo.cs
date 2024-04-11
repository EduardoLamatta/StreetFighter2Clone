using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorGolpeEnemigo : MonoBehaviour
{
    public GameObject activador;

    public PatadasAgachado patadasAgachado;

    public PatadasDelanteras patadasDelanteras;

    public PatadasSaltar patadasSaltar;

    public Pu�osAgachado pu�osAgachado;

    public Pu�osDelanteros pu�osDelanteros;

    public Pu�osSaltar pu�osSaltar;

    public VidaJugador vidaJugador;

    [SerializeField] private float da�oPu�oL, da�oPu�oM, da�oPu�oF;

    [SerializeField] private float da�oPatadaL, da�oPatadaM, da�oPatadaF;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Pu�osNormalesJugador();

            //PatadasNormalesJugador();
        }
    }

    private void Pu�osNormalesJugador()
    {
        if (AtaqueController.instance.GolpeBotL)
        {
            vidaJugador.Da�o(da�oPu�oL);

        }

        if (AtaqueController.instance.GolpeBotM)
        {
            vidaJugador.Da�o(da�oPu�oM);
        }

        if (AtaqueController.instance.GolpeBotF)
        {
            vidaJugador.Da�o(da�oPu�oF);
        }
    }

    private void PatadasNormalesJugador()
    {
        if (AtaqueController.instance.GolpeBotL)
        {
            vidaJugador.Da�o(da�oPatadaL);

        }

        if (AtaqueController.instance.GolpeBotM)
        {
            vidaJugador.Da�o(da�oPatadaM);
        }

        if (AtaqueController.instance.GolpeBotF)
        {
            vidaJugador.Da�o(da�oPatadaF);
        }
    }
}
