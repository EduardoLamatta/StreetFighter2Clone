using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuñosAgachado : MonoBehaviour
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
        if (acciones.agachado == true && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[0]);
            AtaqueController.instance.ataqueAgachado = true;
            animator.SetTrigger("PuñosAgachadoLigera");
        }
    }
   
    public void PuñosMedio()
    {
        if (acciones.agachado == true && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[1]);
            AtaqueController.instance.ataqueAgachado = true;
            animator.SetTrigger("PuñosAgachadoMedia");
        }
    }
    
    public void PuñosFuerte()
    {
        if (acciones.agachado == true && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[2]);
            AtaqueController.instance.ataqueAgachado = true;
            animator.SetTrigger("PuñosAgachadoFuerte");
        }
    }

   



}
