using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    public GameObject[] personajes;

    public GameObject[] Nombrespersonajes;

    void Start()
    {
        Ocultar();

        PersonajeJugable();      
    }

    //El siguiente metodo permite mostrar al personaje seleccionado junto a su respectivo nombre debajo de la barra de vida
    private void PersonajeJugable()
    {

        if (CambioPersonaje.personajesRyu == true)
        {
            personajes[0].SetActive(true);
            Nombrespersonajes[0].SetActive(true);
        }

        if (CambioPersonaje.personajesHonda == true)
        {
            personajes[1].SetActive(true);
            Nombrespersonajes[1].SetActive(true);
        }

        if (CambioPersonaje.personajesBlanka == true)
        {
            personajes[2].SetActive(true);
            Nombrespersonajes[2].SetActive(true);
        }

        if (CambioPersonaje.personajesGuile == true)
        {
            personajes[3].SetActive(true);
            Nombrespersonajes[3].SetActive(true);
        }
        
        if (CambioPersonaje.personajesKen == true)
        {
            personajes[4].SetActive(true);
            Nombrespersonajes[4].SetActive(true);
        }

        if (CambioPersonaje.personajesChunLi == true)
        {
            personajes[5].SetActive(true);
            Nombrespersonajes[5].SetActive(true);
        }

        if (CambioPersonaje.personajesZengief == true)
        {
            personajes[6].SetActive(true);
            Nombrespersonajes[6].SetActive(true);
        }

        if (CambioPersonaje.personajesDhalsim == true)
        {
            personajes[7].SetActive(true);
            Nombrespersonajes[7].SetActive(true);
        }

        }

    //El siguiente metodo oculta todos los personajes antes de empezar la pelea, para que no se superpongan
    private void Ocultar()
    {
        for (int i = 0; i < personajes.Length; i++)
        {
            personajes[i].SetActive(false);
        }
    }





}
