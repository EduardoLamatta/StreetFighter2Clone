using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VozR1 : MonoBehaviour
{

    private AudioSource audioSource;

    public AudioClip audioROUND, audioOne, audioFight; //Hace referencia a las palabras que se dicen al inicio de cada round

    public InicioCombate inicioCombate;

    [SerializeField] private float tiempo1, tiempo2; //tiempos entre cada clip de audio

    public Animator animator;

    private bool audioClip; //booleano usado para que  el audio se ejecute una sola vez

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //Si esta en el inico de la lucha y es el primer round se ejecuta
        if (inicioCombate.inicioLucha && inicioCombate.mostrarR1)
        {                
            animator.SetBool("VozRoundOne", true);
               
            if (!audioClip)                
            {                  
                audioClip = true;
                   
                audioSource.PlayOneShot(audioROUND);
                  
                Invoke("AudioVoz", tiempo1);
                  
                Invoke("AudioFight", tiempo2);
            }
        }
        else if (inicioCombate.EnLucha)
        {
            animator.SetBool("VozRoundOne", false);
        }
    }

    //Los siguientes metodos se usan para las voces al inicio del combate
    private void AudioVoz()
    {
        audioSource.PlayOneShot(audioOne);
    }
    private void AudioFight()
    {
        audioSource.PlayOneShot(audioFight);
    }



}
