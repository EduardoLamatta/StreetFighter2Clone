using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioCombate : MonoBehaviour
{
    [HideInInspector] public bool EnLucha;

    [HideInInspector] public bool inicioLucha;

    public GameObject R1;

    [HideInInspector] public bool mostrarR1;

    public GameObject R2;

    [HideInInspector] public bool mostrarR2;

    public GameObject R3;

    [HideInInspector] public bool mostrarR3;

    void Start()
    {
        EnLucha = false;

        MostrarAnimacionRound();
    }

    
    //El siguiente metodo permite mostrar las animaciones de RoundONe, RoundTwo, FinalRound
    private void MostrarAnimacionRound()
    {
        
        if (ResultadoPartidas.NumDerrotas == 0 && ResultadoPartidas.NumVictorias == 0)
        {
            mostrarR1 = true;

            mostrarR2 = false;

            mostrarR3 = false;

            R1.SetActive(true);
            
            R2.SetActive(false);

            R3.SetActive(false);
        }

        else if (ResultadoPartidas.NumDerrotas + ResultadoPartidas.NumVictorias == 1)
        { 
            mostrarR1 = false;
 
            mostrarR2 = true;
 
            mostrarR3 =false;

            R2.SetActive(true);

            R1.SetActive(false);
           
            R3.SetActive(false);
        }

        else if (ResultadoPartidas.NumDerrotas + ResultadoPartidas.NumVictorias == 2)
        {           
            mostrarR1 = false;

            mostrarR2 = false;

            mostrarR3 = true;
 
            R3.SetActive(true);

            R2.SetActive(false);

            R1.SetActive(false);
        }

    }

}
