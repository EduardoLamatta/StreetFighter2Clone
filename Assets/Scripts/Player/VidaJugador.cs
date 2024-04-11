using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    [HideInInspector] public float cantidadVida;
    [SerializeField] private float vidaMaxima;
    public BarraVidaJugador barrasVida;
    public DañoAnimacion[] dañoAnimacion;

    void Start()
    {
        cantidadVida = vidaMaxima;
        barrasVida.InicializarBarraVidaPersonaje(cantidadVida);
    }


    //El siguiente metodo se usa el Daño producido por el jugador hacia el enemigo
    public void Daño(float dañoRecibido)
    {
        //Debug.Log("jugador: " + cantidadVida);
        cantidadVida -= dañoRecibido;
        barrasVida.CambiarVidaActualPersonaje(cantidadVida);
        AnimacionDaño();
    }


    private void AnimacionDaño()
    {
        if (CambioPersonaje.personajesRyu == true)
        {
            dañoAnimacion[0].AnimacionDañoEnemigo();
        }

        if (CambioPersonaje.personajesHonda == true)
        {
            dañoAnimacion[1].AnimacionDañoEnemigo();
        }

        if (CambioPersonaje.personajesBlanka == true)
        {
            dañoAnimacion[2].AnimacionDañoEnemigo();
        }

        if (CambioPersonaje.personajesGuile == true)
        {
            dañoAnimacion[3].AnimacionDañoEnemigo();
        }

        if (CambioPersonaje.personajesKen == true)
        {
            dañoAnimacion[4].AnimacionDañoEnemigo();
        }

        if (CambioPersonaje.personajesChunLi == true)
        {
            dañoAnimacion[5].AnimacionDañoEnemigo();
        }

        if (CambioPersonaje.personajesZengief == true)
        {
            dañoAnimacion[6].AnimacionDañoEnemigo();
        }

        if (CambioPersonaje.personajesDhalsim == true)
        {
            dañoAnimacion[7].AnimacionDañoEnemigo();
        }

    }

}
