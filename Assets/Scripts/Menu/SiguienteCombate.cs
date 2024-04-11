using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguienteCombate : MonoBehaviour
{
    public GameObject[] Stages;

    public GameObject[] Oponentes;

    public GameObject[] nombresOponentes;

    void Start()
    {
        //Metodo que permite ocultar los escenarios
        OcultarStages();

        //Metodo que permite cambiar de escenario para el siguiente combate
        StagesCombates();
    }

    private void StagesCombates()
    {
        /*if (ResultadoPartidas.NumEnemigosDerrotados == 0)
        {
            CombateContraHonda();
        }

        else if (ResultadoPartidas.NumEnemigosDerrotados == 1)
        {
            CombateContraBlanka();
        }

        else if (ResultadoPartidas.NumEnemigosDerrotados == 2)
        {
            CombateContraGuile();
        }

        else if (ResultadoPartidas.NumEnemigosDerrotados == 3)
        {
            CombateContraRyu();
        }

        else if (ResultadoPartidas.NumEnemigosDerrotados == 4)
        {
            CombateContraZengief();
        }

        else if (ResultadoPartidas.NumEnemigosDerrotados == 5)
        {
            CombateContraKen();
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 6)
        {
            CombateContraChunLi();
        }

        else if (ResultadoPartidas.NumEnemigosDerrotados == 7)
        {
            CombateContraDhalsim();
        }

        else if (ResultadoPartidas.NumEnemigosDerrotados == 8)
        {
            CombateContraVega();
        }

        else if (ResultadoPartidas.NumEnemigosDerrotados == 9)
        {
            CombateContraSagat();
        }

        else if (ResultadoPartidas.NumEnemigosDerrotados == 10)
        {
            CombateContraBison();
        }*/

        //Lleva el cambio de escenario usando el Numero de Enemigos que se derrotan
        switch(ResultadoPartidas.NumEnemigosDerrotados)
        {
            case 0:
                CombateContraHonda();
                break;
            case 1:
                CombateContraBlanka();
                break;
            case 2:
                CombateContraGuile();
                break;
            case 3:
                CombateContraRyu();
                break;
            case 4:
                CombateContraZengief();
                break;
            case 5:
                CombateContraKen();
                break;
            case 6:
                CombateContraChunLi();
                break;
            case 7:
                CombateContraDhalsim();
                break;
            case 8:
                CombateContraVega();
                break;
            case 9:
                CombateContraSagat();
                break;
            case 10:
                CombateContraBison();
                break;
        }
    }

    //Los siguientes metodos se usan para activar los escenarios, los oponentes y los nombres de cada uno
    private void CombateContraHonda()
    {
        Stages[0].SetActive(true);
        Oponentes[0].SetActive(true);
        nombresOponentes[0].SetActive(true);
    }

    private void CombateContraBlanka()
    {
        Stages[1].SetActive(true);
        Oponentes[1].SetActive(true);
        nombresOponentes[1].SetActive(true);
    }

    private void CombateContraGuile()
    {
        Stages[2].SetActive(true);
        Oponentes[2].SetActive(true);
        nombresOponentes[2].SetActive(true);
    }

    private void CombateContraRyu()
    {
        Stages[3].SetActive(true);
        Oponentes[3].SetActive(true);
        nombresOponentes[3].SetActive(true);
    }

    private void CombateContraZengief()
    {
        Stages[4].SetActive(true);
        Oponentes[4].SetActive(true);
        nombresOponentes[4].SetActive(true);
    }

    private void CombateContraKen()
    {
        Stages[5].SetActive(true);
        Oponentes[5].SetActive(true);
        nombresOponentes[5].SetActive(true);
    }

    private void CombateContraChunLi()
    {
        Stages[6].SetActive(true);
        Oponentes[6].SetActive(true);
        nombresOponentes[6].SetActive(true);
    }

    private void CombateContraDhalsim()
    {
        Stages[7].SetActive(true);
        Oponentes[7].SetActive(true);
        nombresOponentes[7].SetActive(true);
    }

    private void CombateContraVega()
    {
        Stages[8].SetActive(true);
        Oponentes[8].SetActive(true);
        nombresOponentes[8].SetActive(true);
    }

    private void CombateContraSagat()
    {
        Stages[9].SetActive(true);
        Oponentes[9].SetActive(true);
        nombresOponentes[9].SetActive(true);
    }

    private void CombateContraBison()
    {
        Stages[10].SetActive(true);
        Oponentes[10].SetActive(true);
        nombresOponentes[10].SetActive(true);
    }


    //El siguiente metodo oculta los escenarios y oponentes
    //se inicia al empezar el juego para que no hayan problemas
    private void OcultarStages()
    {
        for (int i = 0; i < Stages.Length; i++)
        {
            Stages[i].SetActive(false);
            Oponentes[i].SetActive(false);
        }
    }
}
