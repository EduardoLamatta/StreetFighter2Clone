using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaquePatadas : MonoBehaviour
{
    private Animator animator;
    public Acciones acciones;
    public DetectorEnemigoDelante detectorDelante;
    public AudioSource audioSource;
    public Sonidos sonidos;
    public TiempoAtaques tiempoAtaques;
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();   
    }

    //Ataques de puño del player
    public void PatadaLigera()
    {
        if (acciones.agachado == false && acciones.enPiso == true && detectorDelante.enemigoDelante == false && !AtaqueController.instance.ataquePlayer && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[0]);
            AtaqueController.instance.ataquePlayer = true;
            animator.SetTrigger("PatadaLigera");
        }
    }


    public void PatadaMedia()
    { 
        if (acciones.agachado == false && acciones.enPiso == true && detectorDelante.enemigoDelante == false && !AtaqueController.instance.ataquePlayer && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[1]);
            AtaqueController.instance.ataquePlayer = true;
            animator.SetTrigger("PatadaMedia");
        }
    }


    public void PatadaFuerte()
    {
        if (acciones.agachado == false && acciones.enPiso == true && detectorDelante.enemigoDelante == false && !AtaqueController.instance.ataquePlayer && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[2]);
            AtaqueController.instance.ataquePlayer = true;
            animator.SetTrigger("PatadaFuerte");
        }
    }


    

}
