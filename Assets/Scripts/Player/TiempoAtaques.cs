using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoAtaques : MonoBehaviour
{
    public float tiempoSiguienteAtaque;
    [SerializeField] private float tiempoGolpeL, tiempoGolpeM, tiempoGolpeF;
    [HideInInspector] public bool SePuedeAtacar;

    void Update()
    {
        //Correcion del ataque en el player
        SiguienteAtaque();
        CorrecionAtaque();
    }

    //Metodos para corregir el ataque en el player
    public void CorrecionAtaque()
    {
        if (tiempoSiguienteAtaque <= 0)
        {
            SePuedeAtacar = true;

            if (tiempoSiguienteAtaque <= 0)
            {
                SePuedeAtacar = true;
                if (AtaqueController.instance.ataquePlayer)
                {
                    SePuedeAtacar = false;
                    //tiempo para el siguiente ataque, luego de haber lanzado un golpe ligero (L), medio (M), fuerte (F)
                    if (AtaqueController.instance.GolpeL)
                    {
                        tiempoSiguienteAtaque = tiempoGolpeL;
                    }
                    if (AtaqueController.instance.GolpeM)
                    {
                        tiempoSiguienteAtaque = tiempoGolpeM;
                    }
                    if (AtaqueController.instance.GolpeF)
                    {
                        tiempoSiguienteAtaque = tiempoGolpeF;
                    }
                }

               
            }
        }
    }

    private void SiguienteAtaque()
    {
        if (tiempoSiguienteAtaque > 0)
        {
            tiempoSiguienteAtaque -= Time.deltaTime;
            SePuedeAtacar = false;
        }
    }


   
}
