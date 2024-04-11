using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatadasSaltar : MonoBehaviour
{
    private Animator animator;
    public Acciones acciones;
    public AudioSource audioSource;
    public Sonidos sonidos;
    public TiempoAtaques tiempoAtaques;
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    public void PatadaLigera()
    {
        if (acciones.enPiso == false && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[0]);
            AtaqueController.instance.ataqueSaltar = true;
            animator.SetTrigger("PatadaSaltarLigera");
        }
    }
    
    public void PatadaMedia()
    {
        if (acciones.enPiso == false && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[1]);
            AtaqueController.instance.ataqueSaltar = true;
            animator.SetTrigger("PatadaSaltarMedia");
            animator.SetTrigger("PatadaSaltarMedia");
        }
    }
   

    public void PatadaFuerte()
    {
        if (acciones.enPiso == false && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[2]);
            AtaqueController.instance.ataqueSaltar = true;
            animator.SetTrigger("PatadaSaltarFuerte");
        }
    }


}
