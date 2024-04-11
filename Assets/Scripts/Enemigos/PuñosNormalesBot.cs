using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuñosNormalesBot : MonoBehaviour
{
    private Animator animator;
    public AudioSource audioSource;
    public Sonidos sonidos;
    public Acciones acciones;
    public DetectorJugadorDelante detectorDelante;
    public TiempoAtaquesBot tiempoAtaquesBot;
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    //Ataques de puño del bot
    public void PuñoLigeroBot()
    {
        if (acciones.agachado == false && acciones.enPiso == true && detectorDelante.jugadorDelante == false && !AtaqueController.instance.ataqueBot && tiempoAtaquesBot.botPuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[0]);
            AtaqueController.instance.ataqueBot = true;
            animator.SetTrigger("PuñoLigero");
        }
    }

    public void PuñoMedioBot()
    {
        if (acciones.agachado == false && acciones.enPiso == true && detectorDelante.jugadorDelante == false && !AtaqueController.instance.ataqueBot && tiempoAtaquesBot.botPuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[1]);
            AtaqueController.instance.ataqueBot = true;
            animator.SetTrigger("PuñoMedio");
        }
    }

    public void PuñoFuerteBot()
    {
        if (acciones.agachado == false && acciones.enPiso == true && detectorDelante.jugadorDelante == false && !AtaqueController.instance.ataqueBot && tiempoAtaquesBot.botPuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[2]);
            AtaqueController.instance.ataqueBot = true;
            animator.SetTrigger("PuñoFuerte");
        }
    }
}
