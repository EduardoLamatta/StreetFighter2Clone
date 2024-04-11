using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuñosSaltar : MonoBehaviour
{
    private Animator animator;
    public Acciones acciones;
    public AudioSource audioSource;
    public Sonidos sonidos;

    public TiempoAtaques tiempoAtaques;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }


    public void PuñosLigero()
    {
        if (acciones.enPiso == false && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[0]);
            AtaqueController.instance.ataqueSaltar = true;
            animator.SetTrigger("PuñosSaltarLigera");
        }
    }

    public void PuñosMedio()
    {
        if (acciones.enPiso == false && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[1]);
            AtaqueController.instance.ataqueSaltar = true;
            animator.SetTrigger("PuñosSaltarMedia");
        }
    }

    public void PuñosFuerte()
    {
        if (acciones.enPiso == false && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[2]);
            AtaqueController.instance.ataqueSaltar = true;
            animator.SetTrigger("PuñosSaltarFuerte");
        }
    }
  


}
