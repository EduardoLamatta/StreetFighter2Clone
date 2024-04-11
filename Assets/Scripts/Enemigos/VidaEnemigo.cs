using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    [HideInInspector] public float cantidadVida;

    [SerializeField] private float vidaMaxima;

    public BarrasVidaEnemigo barrasVida;

    public DañoAnimacion[] dañoAnimacion;

    void Start()
    {
        cantidadVida = vidaMaxima;
        barrasVida.InicializarBarraVidaPersonaje(cantidadVida);
    }


    //El siguiente metodo se usa el Daño producido por el jugador hacia el enemigo
    public void Daño(float dañoRecibido)
    {
        cantidadVida -= dañoRecibido;
        barrasVida.CambiarVidaActualPersonaje(cantidadVida);
        Debug.Log("Bot: " + cantidadVida);
        AnimacionDaño();
    }


    private void AnimacionDaño()
    {   
        if (ResultadoPartidas.NumEnemigosDerrotados == 0)
        {                
            dañoAnimacion[0].AnimacionDañoEnemigo();
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 1)
        {             
            dañoAnimacion[1].AnimacionDañoEnemigo();
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 2)
        {              
            dañoAnimacion[2].AnimacionDañoEnemigo();
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 3)
        {               
            dañoAnimacion[3].AnimacionDañoEnemigo();
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 4)
        {              
            dañoAnimacion[4].AnimacionDañoEnemigo();
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 5)
        {               
            dañoAnimacion[5].AnimacionDañoEnemigo();
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 6)
        {              
            dañoAnimacion[6].AnimacionDañoEnemigo();
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 7)
        {               
            dañoAnimacion[7].AnimacionDañoEnemigo();
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 8)
        {               
            dañoAnimacion[8].AnimacionDañoEnemigo();
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 9)
        {               
            dañoAnimacion[9].AnimacionDañoEnemigo();
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 10)
        {              
            dañoAnimacion[10].AnimacionDañoEnemigo();
        }

    }
     

}
