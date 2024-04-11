using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraVidaJugador : MonoBehaviour
{
    public Slider sliderPlayer; //Representa la barra de vida del Oponente

    void Start()
    {
        sliderPlayer = GetComponent<Slider>();
    }

    //Inicizliza las barras de vida del oponente
    public void InicializarBarraVidaPersonaje(float vidaPlayer)
    {
        CambiarVidaMaximaPersonaje(vidaPlayer);

        CambiarVidaActualPersonaje(vidaPlayer);
    }

    //Asigna la vida maxima del oponente como el valor maximo del slider 
    public void CambiarVidaMaximaPersonaje(float vidaMaximaPlayer)
    {
        sliderPlayer.maxValue = vidaMaximaPlayer;
    }

    //Cambia el valor del slider al asignar el valor de la vida del oponente
    public void CambiarVidaActualPersonaje(float vidaActualPlayer)
    {
        sliderPlayer.value = vidaActualPlayer;
    }

}
