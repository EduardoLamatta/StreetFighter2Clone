using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    [HideInInspector] public float cantidadVida;
    [SerializeField] private float vidaMaxima;
    public BarraVidaJugador barrasVida;
    public Da�oAnimacion[] da�oAnimacion;

    void Start()
    {
        cantidadVida = vidaMaxima;
        barrasVida.InicializarBarraVidaPersonaje(cantidadVida);
    }


    //El siguiente metodo se usa el Da�o producido por el jugador hacia el enemigo
    public void Da�o(float da�oRecibido)
    {
        //Debug.Log("jugador: " + cantidadVida);
        cantidadVida -= da�oRecibido;
        barrasVida.CambiarVidaActualPersonaje(cantidadVida);
        AnimacionDa�o();
    }


    private void AnimacionDa�o()
    {
        if (CambioPersonaje.personajesRyu == true)
        {
            da�oAnimacion[0].AnimacionDa�oEnemigo();
        }

        if (CambioPersonaje.personajesHonda == true)
        {
            da�oAnimacion[1].AnimacionDa�oEnemigo();
        }

        if (CambioPersonaje.personajesBlanka == true)
        {
            da�oAnimacion[2].AnimacionDa�oEnemigo();
        }

        if (CambioPersonaje.personajesGuile == true)
        {
            da�oAnimacion[3].AnimacionDa�oEnemigo();
        }

        if (CambioPersonaje.personajesKen == true)
        {
            da�oAnimacion[4].AnimacionDa�oEnemigo();
        }

        if (CambioPersonaje.personajesChunLi == true)
        {
            da�oAnimacion[5].AnimacionDa�oEnemigo();
        }

        if (CambioPersonaje.personajesZengief == true)
        {
            da�oAnimacion[6].AnimacionDa�oEnemigo();
        }

        if (CambioPersonaje.personajesDhalsim == true)
        {
            da�oAnimacion[7].AnimacionDa�oEnemigo();
        }

    }

}
