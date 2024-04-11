using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuñosDelanteros : MonoBehaviour
{
private Animator animator;
    public Player player;
    public AudioSource audioSource;
    public Sonidos sonidos;
    public DetectorEnemigoDelante detectorDelante;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    public void PuñoLigera()
    {
        if (detectorDelante.enemigoDelante == true)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[0]);
            AtaqueController.instance.ataqueDelante = true;
        }
    }

    
    public void PuñoMedia()
    {
        if (detectorDelante.enemigoDelante == true)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[1]);
            AtaqueController.instance.ataqueDelante = true;
        }
    }
    
    public void PuñoFuerte()
    {
        if (detectorDelante.enemigoDelante == true)
        {
            audioSource.PlayOneShot(sonidos.audioClipsAtaques[2]);
            AtaqueController.instance.ataqueDelante = true;
        }
    }

}
