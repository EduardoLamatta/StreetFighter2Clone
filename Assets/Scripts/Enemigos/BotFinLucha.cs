using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotFinLucha : MonoBehaviour
{
    [HideInInspector] public bool Derrotado;
    public ResultadoPartidas resultadoPartidas;
    public VidaEnemigo vidaEnemigo;
    public VidaJugador vidaJugador;
    private Animator animator;
    private float AnimacionNum;
    [HideInInspector] public bool KOJugador;

    void Start()
    {
        Derrotado = false;
        animator = GetComponent<Animator>();
        KOJugador = false;
    }
    
    void Update()
    {

        if (vidaJugador.cantidadVida <= 0 && !KOJugador)
        {
            KOJugador = true;
            Invoke("AnimacionVictoria", 2.0f);
        }

        //El siguiente codigo es parte de la derrota del bot, contabiliza una victoria y permite la animación de derrota del bot
        if (vidaEnemigo.cantidadVida <= 0)
        {
            animator.SetBool("KO", true);

            if (!Derrotado)
            {
                Derrotado = true;
                resultadoPartidas.ContadorVictorias();
            }
        }
    }



    private void AnimacionVictoria()
    {
        AnimacionNum = Random.Range(0, 2);

        if (AnimacionNum == 0)
        {
            animator.SetBool("Victoria1", true);
        }
        else if (AnimacionNum == 1)
        {
            animator.SetBool("Victoria2", true);
        }

    }
}
