using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Salir : MonoBehaviour
{
    public GameObject FadeOut;

    [SerializeField] private float TiempoSalir;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            SalirDelJuego();

        }
    }


    public void SalirDelJuego()
    {

        ActivarFadeOut();

        Invoke("SalirJuego", TiempoSalir);

    }



    private void ActivarFadeOut()
    {

        FadeOut.SetActive(true);

    }



    private void SalirJuego()
    {

        Application.Quit();

    }






}
