using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicionInicio : MonoBehaviour
{
    [SerializeField] private float tiempoEmpezarPelea;

    [SerializeField] private float tiempoParaFadeOut;

    public GameObject ObjectFadeOut;

    public GameObject[] personajesTransicion;

    public GameObject[] OponentesTransicion;

    private void Awake() 
    {
        Invoke("IniciarPelea", tiempoEmpezarPelea);   //tiempo para empezar la pelea
        
        Invoke("ActivarFadeOut", tiempoParaFadeOut);    //tiempo para que aparezca el fadeout
    }

    void Start()
    {
        OcultarOponentes();

        Personjes();
        
        Oponentes();
    }

    //El siguiente metodo permite mostrar las imagens del personaje que eligio el jugador
    private void Personjes()
    {
        if (CambioPersonaje.personajesRyu)
        {
            personajesTransicion[0].SetActive(true);
        }

        if (CambioPersonaje.personajesHonda)
        {
            personajesTransicion[1].SetActive(true);
        }

        if (CambioPersonaje.personajesBlanka)
        {
            personajesTransicion[2].SetActive(true);
        }

        if (CambioPersonaje.personajesGuile)
        {
            personajesTransicion[3].SetActive(true);
        }
        
        if (CambioPersonaje.personajesKen)
        {
            personajesTransicion[4].SetActive(true);
        }

        if (CambioPersonaje.personajesChunLi)
        {
            personajesTransicion[5].SetActive(true);
        }

        if (CambioPersonaje.personajesZengief)
        {
            personajesTransicion[6].SetActive(true);
        }

        if (CambioPersonaje.personajesDhalsim)
        {
            personajesTransicion[7].SetActive(true);
        }
    }

    //El siguiente metodo permite mostrar la imagen del siguiente enemigo al que el jugador se va a enfrentar
    //Para hacerlo usa el número de enemigos derrotados
    private void Oponentes()
    {
        /*if (ResultadoPartidas.NumEnemigosDerrotados == 0)
        {
            OponentesTransicion[0].SetActive(true);
        }

        else if (ResultadoPartidas.NumEnemigosDerrotados == 1)
        {
            OponentesTransicion[1].SetActive(true);
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 2)
        {
            OponentesTransicion[2].SetActive(true);
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 3)
        {
            OponentesTransicion[3].SetActive(true);
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 4)
        {
            OponentesTransicion[4].SetActive(true);
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 5)
        {
            OponentesTransicion[5].SetActive(true);
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 6)
        {
            OponentesTransicion[6].SetActive(true);
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 7)
        {
            OponentesTransicion[7].SetActive(true);
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 8)
        {
            OponentesTransicion[8].SetActive(true);
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 9)
        {
            OponentesTransicion[9].SetActive(true);
        }
        else if (ResultadoPartidas.NumEnemigosDerrotados == 10)
        {
            OponentesTransicion[10].SetActive(true);
        }*/

         switch(ResultadoPartidas.NumEnemigosDerrotados)
        {
            case 0:
                OponentesTransicion[0].SetActive(true);
                break;
            case 1:
                OponentesTransicion[1].SetActive(true);
                break;
            case 2:
                OponentesTransicion[2].SetActive(true);
                break;
            case 3:
                OponentesTransicion[3].SetActive(true);
                break;
            case 4:
                OponentesTransicion[4].SetActive(true);
                break;
            case 5:
                OponentesTransicion[5].SetActive(true);
                break;
            case 6:
                OponentesTransicion[6].SetActive(true);
                break;
            case 7:
                OponentesTransicion[7].SetActive(true);
                break;
            case 8:
                OponentesTransicion[8].SetActive(true);
                break;
            case 9:
                OponentesTransicion[9].SetActive(true);
                break;
            case 10:
                OponentesTransicion[10].SetActive(true);
                break;
        }
    }

    //El siguiente metodo Oculta las imagenes de todos los oponentes, para que no se superpongan
    private void OcultarOponentes()
    {
        for (int i = 0; i < OponentesTransicion.Length; i++)
        {
            OponentesTransicion[i].SetActive(false);
        }
    }

    //El siguietne metodo permite el cambio a la escena de "Combates"
    private void IniciarPelea() 
    {
        SceneManager.LoadScene(6);
    }
    
    //El siguiente metodo activa el fadeout
    private void ActivarFadeOut()
    {
        ObjectFadeOut.SetActive(true); 
    }



}
