using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoAtaquesBot : MonoBehaviour
{
    public float tiempoBotSiguienteAtaque;
    [SerializeField] private float tiempoGolpeBotL, tiempoGolpeBotM, tiempoGolpeBotF;
    [HideInInspector] public bool botPuedeAtacar;

    void Update()
    {
        //Correcion del ataque en el bot
        SiguienteAtaqueBot();
        CorrecionAtaqueBot();
    }

    //Metodos para corregir el ataque en el bot
    public void CorrecionAtaqueBot()
    {
        if (tiempoBotSiguienteAtaque <= 0)
        {
            botPuedeAtacar = true;

            if (tiempoBotSiguienteAtaque <= 0)
            {
                botPuedeAtacar = true;
                if (AtaqueController.instance.ataqueBot)
                {
                    botPuedeAtacar = false;
                    //tiempo para el siguiente ataque, luego de haber lanzado un golpe ligero (L), medio (M), fuerte (F)
                    if (AtaqueController.instance.GolpeBotL)
                    {
                        tiempoBotSiguienteAtaque = tiempoGolpeBotL;
                    }
                    if (AtaqueController.instance.GolpeBotM)
                    {
                        tiempoBotSiguienteAtaque = tiempoGolpeBotM;
                    }
                    if (AtaqueController.instance.GolpeBotF)
                    {
                        tiempoBotSiguienteAtaque = tiempoGolpeBotF;
                    }
                }
            }
        }
    }

    private void SiguienteAtaqueBot()
    {
        if (tiempoBotSiguienteAtaque > 0)
        {
            tiempoBotSiguienteAtaque -= Time.deltaTime;
            botPuedeAtacar = false;
        }
    }
}
