using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioPersonaje : MonoBehaviour
{
    public GameObject[] Personajes;

    public GameObject[] BanderasColor;

    static public bool personajesRyu, personajesHonda, personajesBlanka, personajesGuile, personajesKen, personajesChunLi, personajesZengief, personajesDhalsim;
    
    [SerializeField] private int NumPersonajes;

    private void Start() 
    {
        personajesRyu = false;
    }


    //El siguiente metodo permite cambiar el personaje y la badera de su respectivo pais dependiendo de donde esta el selector
    //Lo hace a través de un Trigger en cada una de las imagenes que toca el selector
    //Cada trigger hace referencia a un personaje distint0
    //Además, toma el valor bool de cada personaje y permite jugar con el personaje elegido en el combate
    private void OnTriggerEnter2D(Collider2D other) 
    {
        /*if (other.tag == "Ryu")
        {
            OcultarPersonaje();
            Personajes[0].SetActive(true);
            BanderasColor[0].SetActive(true);
            personajesRyu = true;
        }
        else if (other.tag == "Honda")
        {
            OcultarPersonaje();
            Personajes[1].SetActive(true);
            BanderasColor[1].SetActive(true);
            personajesHonda = true;
        }
        else if (other.tag == "Blanka")
        {
            OcultarPersonaje();
            Personajes[2].SetActive(true);
            BanderasColor[2].SetActive(true);
            personajesBlanka = true;
        }
        else if (other.tag == "Guile")
        {
            OcultarPersonaje();
            Personajes[3].SetActive(true);
            BanderasColor[3].SetActive(true);
            personajesGuile = true;
        }
        else if (other.tag == "Ken")
        {
            OcultarPersonaje();
            Personajes[4].SetActive(true);
            BanderasColor[4].SetActive(true);
            personajesKen = true;
        }
        else if (other.tag == "Chun-Li")
        {
            OcultarPersonaje();
            Personajes[5].SetActive(true);
            BanderasColor[5].SetActive(true);
            personajesChunLi = true;
        }
        else if (other.tag == "Zengief")
        {
            OcultarPersonaje();
            Personajes[6].SetActive(true);
            BanderasColor[6].SetActive(true);
            personajesZengief = true;
        }
        else if (other.tag == "Dhalsim")
        {
            OcultarPersonaje();
            Personajes[7].SetActive(true);
            BanderasColor[7].SetActive(true);
            personajesDhalsim = true;
        }*/


        switch(other.tag)
        {
            case "Ryu":
                OcultarPersonaje();
                Personajes[0].SetActive(true);
                BanderasColor[0].SetActive(true);
                personajesRyu = true;
                break;
            case "Honda":
                OcultarPersonaje();
                Personajes[1].SetActive(true);
                BanderasColor[1].SetActive(true);
                personajesHonda = true;
                break;
            case "Blanka":
                OcultarPersonaje();
                Personajes[2].SetActive(true);
                BanderasColor[2].SetActive(true);
                personajesBlanka = true;
                break;
            case "Guile":
                OcultarPersonaje();
                Personajes[3].SetActive(true);
                BanderasColor[3].SetActive(true);
                personajesGuile = true;
                break;
            case "Ken":
                OcultarPersonaje();
                Personajes[4].SetActive(true);
                BanderasColor[4].SetActive(true);
                personajesKen = true;
                break;
            case "Chun-Li":
                OcultarPersonaje();
                Personajes[5].SetActive(true);
                BanderasColor[5].SetActive(true);
                personajesChunLi = true;
                break;
            case "Zengief":
                OcultarPersonaje();
                Personajes[6].SetActive(true);
                BanderasColor[6].SetActive(true);
                personajesZengief = true;
                break;
            case "Dhalsim":
                OcultarPersonaje();
                Personajes[7].SetActive(true);
                BanderasColor[7].SetActive(true);
                personajesDhalsim = true;
                break;
        }
    }

    //el siguiente método desactiva las imagenes y permite que bo hayan errores al elegirlos
    private void OnTriggerExit2D(Collider2D other) 
    {
        /*if (other.tag == "Ryu")
        {
            personajesRyu = false;
        }
        else if (other.tag == "Honda")
        {
            personajesHonda = false;
        }
        else if (other.tag == "Blanka")
        {
            personajesBlanka = false;
        }
        else if (other.tag == "Guile")
        {
            personajesGuile = false;
        }
        else if (other.tag == "Ken")
        {
            personajesKen = false;
        }
        else if (other.tag == "Chun-Li")
        {
            personajesChunLi = false;
        }
        else if (other.tag == "Zengief")
        {
            personajesZengief = false;
        }
        else if (other.tag == "Dhalsim")
        {
            personajesDhalsim = false;
        } */

        switch(other.tag)
        {
            case "Ryu":
                personajesRyu = false;
                break;
            case "Honda":
                personajesHonda = false;
                break;
            case "Blanka":
                personajesBlanka = false;
                break;
            case "Guile":
                personajesGuile = false;
                break;
            case "Ken":
                personajesKen = false;
                break;
            case "Chun-Li":
                personajesChunLi = false;
                break;
            case "Zengief":
                personajesZengief = false;
                break;
            case "Dhalsim":
                personajesDhalsim = false;
                break;
        }
    }


    //El siguiente metodo oculta los personajes y las banderas de cada pais al que pertenecen
    private void OcultarPersonaje()
    {
        for (int i = 0; i < NumPersonajes; i++)
        {
            Personajes[i].SetActive(false);
            BanderasColor[i].SetActive(false);
        }
    }

}
