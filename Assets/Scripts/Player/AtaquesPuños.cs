using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaquesPuños : MonoBehaviour
{
    private Animator animator;
    public AudioSource audioSource;
    public Sonidos sonidos;
    public Acciones acciones;
    public DetectorEnemigoDelante detectorDelante;
    public TiempoAtaques tiempoAtaques;
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    //Ataques de puño del player
    public void PuñoLigero()
    {        
        if (!acciones.agachado && acciones.enPiso && !detectorDelante.enemigoDelante && !AtaqueController.instance.ataquePlayer && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[0]);
            AtaqueController.instance.ataquePlayer = true;
            animator.SetTrigger("PuñoLigero");
        }
    }

    public void PuñoMedio()
    {
        if (!acciones.agachado && acciones.enPiso && !detectorDelante.enemigoDelante && !AtaqueController.instance.ataquePlayer && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[1]);
            AtaqueController.instance.ataquePlayer = true;
            animator.SetTrigger("PuñoMedio");
        }
    }
    public void PuñoFuerte()
    {
        if (!acciones.agachado && acciones.enPiso && !detectorDelante.enemigoDelante && !AtaqueController.instance.ataquePlayer && tiempoAtaques.SePuedeAtacar)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[2]);
            AtaqueController.instance.ataquePlayer = true;
            animator.SetTrigger("PuñoFuerte");
        }
    }


  
}
