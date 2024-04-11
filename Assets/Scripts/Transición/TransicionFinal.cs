using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicionFinal : MonoBehaviour
{

    [SerializeField] private float tiempoVolverAlMenu;
    [SerializeField] private float tiempoParaFadeOut;
    public GameObject ObjectFadeOut;
    public GameObject[] personajesTransicion; //Hace referencia a los personajes que se pueden elegir
    public GameObject[] OponentesTransicion;  //Hace referencia a los oponentes contra los que se va a enfrentar

    private void Awake() 
    {
        Invoke("IniciarPelea", tiempoVolverAlMenu);  
        Invoke("ActivarFadeOut", tiempoParaFadeOut);
    }

    
    void Start()
    {
        OcultarOponentes();
        Personajes();
        Oponentes();
    }

    //el siguiente metodo permite mostrar el personaje elegido por el jugador
    private void Personajes()
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

    //El siguiente metodo permite mostrar al enemigo con el que el jugador se enfrento
     private void Oponentes()
    {
        switch (ResultadoPartidas.NumEnemigosDerrotados)
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

    //El siguiente metodo permite el cambio de escena hacia la escena del Menu
    private void IniciarPelea()
    {
        SceneManager.LoadScene(7);
    }

    //El siguiente metodo oculta los oponentes para que no se superpongan
    private void OcultarOponentes()
    {
        for (int i = 0; i < OponentesTransicion.Length; i++)
        {
            OponentesTransicion[i].SetActive(false);
        }
    }
        
    private void ActivarFadeOut()
    {
        ObjectFadeOut.SetActive(true); 
    }


}
