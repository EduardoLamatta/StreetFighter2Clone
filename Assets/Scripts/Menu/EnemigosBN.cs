using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigosBN : MonoBehaviour
{
    public GameObject[] EnemigosDesactivar; //permite desactivar las iamgenes a color de los personajes
    public GameObject[] Marcas;  //representa las aspas que aparecen al derrotar un enemigo

    void Start()
    {
        //Permite mostrar las Aspas (Marcas) que representan los enemigos derrotados
        //Tambien desactiva las imagenes a color deajndo solo el cuadro a blanco y negro
        if (ResultadoPartidas.NumEnemigosDerrotados  > 0)
        {
            EnemigosDesactivar[0].SetActive(false);
            Marcas[0].SetActive(true);
        }
        if (ResultadoPartidas.NumEnemigosDerrotados  > 1)
        {
            EnemigosDesactivar[1].SetActive(false);
            Marcas[1].SetActive(true);
        }
        if (ResultadoPartidas.NumEnemigosDerrotados  > 2)
        {
            EnemigosDesactivar[2].SetActive(false);
            Marcas[2].SetActive(true);
        }
        if (ResultadoPartidas.NumEnemigosDerrotados  > 3)
        {
            EnemigosDesactivar[3].SetActive(false);
            Marcas[3].SetActive(true);
        }
        if (ResultadoPartidas.NumEnemigosDerrotados  > 4)
        {
            EnemigosDesactivar[4].SetActive(false);
            Marcas[4].SetActive(true);
        }
        if (ResultadoPartidas.NumEnemigosDerrotados  > 5)
        {
            EnemigosDesactivar[5].SetActive(false);
            Marcas[5].SetActive(true);
        }
        if (ResultadoPartidas.NumEnemigosDerrotados  > 6)
        {
            EnemigosDesactivar[6].SetActive(false);
            Marcas[6].SetActive(true);
        }
        
        if (ResultadoPartidas.NumEnemigosDerrotados  > 7)
        {
            EnemigosDesactivar[7].SetActive(false);
            Marcas[7].SetActive(true);
        }

    }
}
