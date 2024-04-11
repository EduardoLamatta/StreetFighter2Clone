using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCombate : MonoBehaviour
{
    [HideInInspector] public bool finLucha;

    public InicioCombate inicioCombate;

    public GameObject fadeOut;

    public VidaEnemigo vidaEnemigo;

    [SerializeField] private float tiempoParaFadeOut;

    void Update()
    {
        if (vidaEnemigo.cantidadVida <= 0)
        {
            finLucha = true;
        }

        if (finLucha)
        {
            inicioCombate.EnLucha = false;
            Invoke("inicicarFadeOut", tiempoParaFadeOut);
        }

       

    }


    private void inicicarFadeOut()
    {
        fadeOut.SetActive(true);
    }




}
