using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Finales : MonoBehaviour
{
    public GameObject[] EscenaFinal;

    private void Start() 
    {
        OcultarFinales();

        FinalesPersonajes();
    }

    //El siguiente metodo reproduce los finales del personaje elegido
    private void FinalesPersonajes()
    {
        if (CambioPersonaje.personajesRyu)
        {
            EscenaFinal[0].SetActive(true);
        }

        if (CambioPersonaje.personajesHonda)
        {
            EscenaFinal[1].SetActive(true);
        }

        if (CambioPersonaje.personajesBlanka)
        {
            EscenaFinal[2].SetActive(true);
        }

        if (CambioPersonaje.personajesGuile)
        {
            EscenaFinal[3].SetActive(true);
        }

        if (CambioPersonaje.personajesKen)
        {
            EscenaFinal[4].SetActive(true);
        }

        if (CambioPersonaje.personajesChunLi)
        {
            EscenaFinal[5].SetActive(true);
        }

        if (CambioPersonaje.personajesZengief)
        {
            EscenaFinal[6].SetActive(true);
        }

        if (CambioPersonaje.personajesDhalsim)
        {
            EscenaFinal[7].SetActive(true);
        }
    }

    //el siguiente metodo oculta todos los finales para que no se superpongan
    private void OcultarFinales()
    {
        for (int i = 0; i < EscenaFinal.Length; i++)
        {
            EscenaFinal[i].SetActive(false);
        }
    }


}
