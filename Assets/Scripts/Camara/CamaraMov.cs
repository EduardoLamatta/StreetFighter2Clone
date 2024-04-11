using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMov : MonoBehaviour
{
    public GameObject[] camaraPersonaje;

    void Start()
    {
        OcultarCamaras();

        CamaraPersonajes();
    }

    //El siguiente metodo permite asignar una camara propia al personaje elegido
    private void CamaraPersonajes()
    {
        if (CambioPersonaje.personajesRyu)
        {
            camaraPersonaje[0].SetActive(true);
        }

        if (CambioPersonaje.personajesHonda)
        {
            camaraPersonaje[1].SetActive(true);
        }

        if (CambioPersonaje.personajesBlanka)
        {
            camaraPersonaje[2].SetActive(true);
        }

        if (CambioPersonaje.personajesGuile)
        {
            camaraPersonaje[3].SetActive(true);
        }

        if (CambioPersonaje.personajesKen)
        {
            camaraPersonaje[4].SetActive(true);
        }

        if (CambioPersonaje.personajesChunLi)
        {
            camaraPersonaje[5].SetActive(true);
        }

        if (CambioPersonaje.personajesZengief)
        {
            camaraPersonaje[6].SetActive(true);
        }

        if (CambioPersonaje.personajesDhalsim)
        {
            camaraPersonaje[7].SetActive(true);
        }
    }

    //El siguiente metodo oculta todas las camaras para no producir errores
    private void OcultarCamaras()
    {
        for (int i = 0; i < camaraPersonaje.Length; i++)
        {
            camaraPersonaje[i].SetActive(false);
        }
    }


}
