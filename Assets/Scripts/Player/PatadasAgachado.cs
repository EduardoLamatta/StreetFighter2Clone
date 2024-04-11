using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatadasAgachado : MonoBehaviour
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
        if (acciones.agachado == true && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[0]);
            AtaqueController.instance.ataqueAgachado = true;
            animator.SetTrigger("PatadaAgachadoLigera");
        }
    }

    
    public void PatadaMedia()
    {
        if (acciones.agachado == true && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[1]);
            AtaqueController.instance.ataqueAgachado = true;
            animator.SetTrigger("PatadaAgachadoMedia");
        }
    }
    
    public void PatadaFuerte()
    {
        if (acciones.agachado == true && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[2]);
            AtaqueController.instance.ataqueAgachado = true;
            animator.SetTrigger("PatadaAgachadoFuerte");
        }
        
    }




}
