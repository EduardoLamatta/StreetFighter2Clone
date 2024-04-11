using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatadasNormalesBot : MonoBehaviour
{
    private Animator animator;
    public Acciones acciones;
    public DetectorJugadorDelante detectorDelante;
    public AudioSource audioSource;
    public Sonidos sonidos;
    public TiempoAtaquesBot tiempoAtaquesBot;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    //Ataques de puño del bot 
    public void PatadaLigeraBot()
    {
        if (acciones.agachado == false && acciones.enPiso == true && detectorDelante.jugadorDelante == false && !AtaqueController.instance.ataqueBot && tiempoAtaquesBot.botPuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[0]);
            AtaqueController.instance.ataqueBot = true;
            animator.SetTrigger("PatadaLigera");
        }
    }


    public void PatadaMediaBot()
    {
        if (acciones.agachado == false && acciones.enPiso == true && detectorDelante.jugadorDelante == false && !AtaqueController.instance.ataqueBot && tiempoAtaquesBot.botPuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[1]);
            AtaqueController.instance.ataqueBot = true;
            animator.SetTrigger("PatadaMedia");
        }
    }


    public void PatadaFuerteBot()
    {
        if (acciones.agachado == false && acciones.enPiso == true && detectorDelante.jugadorDelante == false && !AtaqueController.instance.ataqueBot && tiempoAtaquesBot.botPuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[2]);
            AtaqueController.instance.ataqueBot = true;
            animator.SetTrigger("PatadaFuerte");
        }
    }
}
