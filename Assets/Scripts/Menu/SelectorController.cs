using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectorController : MonoBehaviour
{
    [SerializeField] private float distanciaHorizontal;

    [SerializeField] private float distanciaVertical;

    private AudioSource audioSourceMenu;

    public AudioClip[] audioClipsMenu;

    public CambioPersonaje cambioPersonaje;

    public GameObject selectorPersonaje;

    [SerializeField] private float tiempoFadeOut;

    public bool elegido;

    static private Vector3 posicion = new Vector3(-0.181f, -0.36f, -8.31f);

    void Start()
    {
        audioSourceMenu = GetComponent<AudioSource>();

        //toma la posicion del selector
        selectorPersonaje.transform.position = posicion;
    }

    private void Update() 
    {
        //Metodo que permite saber si se ha elegido un personaje
        SeleccionHecha();

        //metodos que permiten al selector moverse en horizontal y vertical
        SelectorArriba();

        SelectorAbajo();

        SelectorDerecha();

        SelectorIzquierda();
    }

    public void SeleccionHecha()
    {
        //Solo permite elegir un solo personaje, aun si se presiona enter varias veces
        if (!elegido && !ResultadoPartidas.Ganaste && Input.GetKeyDown(KeyCode.Return))
        {
            elegido = true;

            audioSourceMenu.PlayOneShot(audioClipsMenu[1]);
        }
    }

    //Los siguietnes metodos permite que el selector se mueva en horizontal y vertical
    //Funciona sumando o restando un numero hacia la direccion en la que se desea ir
    public void SelectorArriba()   //Permite al selector moverse hacia arriba
    {

        if (selectorPersonaje.transform.position.y < -0.4 && !elegido && !ResultadoPartidas.Ganaste && Input.GetKeyDown(KeyCode.W))
        {
            selectorPersonaje.transform.Translate(new Vector3(0.0f, distanciaVertical, 0.0f));

            audioSourceMenu.PlayOneShot(audioClipsMenu[0]);

            posicion = selectorPersonaje.transform.position;
        }
    }

    public void SelectorAbajo()   //Permite al selector moverse hacia abajo
    {

        if (selectorPersonaje.transform.position.y > -0.7 && !elegido && !ResultadoPartidas.Ganaste && Input.GetKeyDown(KeyCode.S))
        {
            selectorPersonaje.transform.Translate(new Vector3(0.0f, -distanciaVertical, 0.0f));

            audioSourceMenu.PlayOneShot(audioClipsMenu[0]);

            posicion = selectorPersonaje.transform.position;
        }
    }

    public void SelectorIzquierda()   //Permite al selector moverse hacia la izquierda
    {

        if (selectorPersonaje.transform.position.x > 0.14 && !elegido && !ResultadoPartidas.Ganaste && Input.GetKeyDown(KeyCode.A))
        {         
            selectorPersonaje.transform.Translate(new Vector3(-distanciaHorizontal, 0.0f, 0.0f));

            audioSourceMenu.PlayOneShot(audioClipsMenu[0]);

            posicion = selectorPersonaje.transform.position;
        }
        
    }

    public void SelectorDerecha()   //Permite al selector moverse hacia la derecha
    {

        if (selectorPersonaje.transform.position.x < 0.8 && !elegido && !ResultadoPartidas.Ganaste && Input.GetKeyDown(KeyCode.D))
        {
            selectorPersonaje.transform.Translate(new Vector3(distanciaHorizontal, 0.0f, 0.0f));

            audioSourceMenu.PlayOneShot(audioClipsMenu[0]);

            posicion = selectorPersonaje.transform.position;
        }

    }


   

}
