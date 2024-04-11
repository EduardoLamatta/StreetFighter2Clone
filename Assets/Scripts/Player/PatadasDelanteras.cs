using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatadasDelanteras : MonoBehaviour
{
    private Animator animator;
    public Acciones acciones;
    public AudioSource audioSource;
    public Sonidos sonidos;
    public DetectorEnemigoDelante detectorDelante;
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void PatadaLigera()
    {
        if (detectorDelante.enemigoDelante == true)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[0]);
            AtaqueController.instance.ataqueDelante = true;
        }
    }

    
    public void PatadaMedia()
    {
        if (detectorDelante.enemigoDelante == true)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[1]);
            AtaqueController.instance.ataqueDelante = true;
        }
    }
    

    public void PatadaFuerte()
    {
        if (detectorDelante.enemigoDelante == true)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[2]);
            AtaqueController.instance.ataqueDelante = true;
        }
    }

}
