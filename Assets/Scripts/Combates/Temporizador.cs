using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temporizador : MonoBehaviour
{
    public InicioCombate inicioCombate;

    public GameObject Decenas; //Hace referencia a las decenas de los numeros del temporizador

    public Animator animatorDecenas;

    public GameObject Unidades; //Hace referencia a las unidades de los numeros del temporizador

    public Animator animatorUnidades;

    [SerializeField] private float tiempoTemporizador;

    void Start()
    {
        Decenas.SetActive(false);

        Unidades.SetActive(false);
    }


    void Update()
    {            
        IniciarTemporizador();
                    
        DetenerTemporizador();
    }


    private void IniciarTemporizador()
    {
        //Activa las unidades y decenas
        if (inicioCombate.inicioLucha)
        {
            Decenas.SetActive(true);

            Unidades.SetActive(true);

        }

        //Permite que el temporizador funcione al mismo tiempo que el jugador puede jugar
        if (inicioCombate.EnLucha && tiempoTemporizador > 0)
        {
            tiempoTemporizador -= Time.deltaTime;

            animatorDecenas.SetBool("Decenas", true);

            animatorUnidades.SetBool("Unidades", true);
        }


    }

    //El temporizador se detiene al llegar a cero, pero aun falta que se detenga al ganar o perder
    private void DetenerTemporizador()
    {
        if (tiempoTemporizador <= 0)
        {
            animatorUnidades.SetBool("Unidades", false);

            animatorUnidades.SetBool("Cero", true);
        }
    }



}
