using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerFinLucha : MonoBehaviour
{
    [HideInInspector] public bool playerDerrotado;
    public ResultadoPartidas resultadoPartidas;
    public VidaEnemigo vidaEnemigo;
    public VidaJugador vidaJugador;
    private Animator animator;
    private float AnimacionNum;
    [HideInInspector] public bool KOEnemigo;
    void Start()
    {
        playerDerrotado = false;
        animator = GetComponent<Animator>();
        KOEnemigo = false;
    }
    
    void Update()
    {
        if(vidaEnemigo.cantidadVida <= 0 && !KOEnemigo)
        {
            KOEnemigo = true;
            Invoke("AnimacionVictoria", 2.0f);
        }

        // El siguiente codigo es parte de la derrota del player, contabiliza una victoria y permite la animación de derrota del player
        if (vidaJugador.cantidadVida <= 0)
        {
            animator.SetBool("KO", true);

            if (!playerDerrotado)
            {
                playerDerrotado = true;
                resultadoPartidas.ContadorDerrotas();
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