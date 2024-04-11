using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarrasVidaEnemigo : MonoBehaviour
{
    public Slider sliderBot; //Representa la barra de vida del Oponente

    void Start()
    {
        sliderBot = GetComponent<Slider>(); 
    }

    //Inicizliza las barras de vida del oponente
    public void InicializarBarraVidaPersonaje(float vidaBot)
    {
        CambiarVidaMaximaPersonaje(vidaBot);

        CambiarVidaActualPersonaje(vidaBot);
    }

    //Asigna la vida maxima del oponente como el valor maximo del slider 
    public void CambiarVidaMaximaPersonaje(float vidaMaximaBot)
    {
        sliderBot.maxValue = vidaMaximaBot;
    }

    //Cambia el valor del slider al asignar el valor de la vida del oponente
    public void CambiarVidaActualPersonaje(float vidaActualBot)
    {
        sliderBot.value = vidaActualBot;
    }

}
