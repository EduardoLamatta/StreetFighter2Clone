using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultadoPartidas : MonoBehaviour
{
    public InicioCombate inicioCombate;
    public FinalCombate finalCombate;
    static public int NumDerrotas;
    static public int NumVictorias;
    static public int NumEnemigosDerrotados;
    static public bool Perdiste;
    static public bool Ganaste;
    public GameObject[] Manitos; //Hace referencia a las manitos que aparecen al lado de la barra de vida al ganar un combate
    [SerializeField] private float tiempoParaReiniciarEscena;
    

    void Awake()
    {
        if (Ganaste == true || Perdiste == true)
        {
            NumDerrotas = 0;

            NumVictorias = 0;
        }

        Perdiste = false;

        Ganaste = false;

        
    }

    void Update()
    {
        Derrota();

        Victoria();

        //De momento este condicional permite asignar una derrota
        if (Input.GetKeyDown(KeyCode.M))
        {
            ContadorDerrotas();
        }

        //Manito GanaPlayer:
        if (NumDerrotas >= 1) Manitos[0].SetActive(true);

        //Manito GanaBot
        if (NumVictorias >= 1) Manitos[2].SetActive(true);
    }

    //El siguiente metodo permite realizar algunas acciones al ser derrotado
    private void Derrota()
    {
        if (NumDerrotas >= 2 && NumDerrotas > NumVictorias && !Perdiste)
        {
            Manitos[1].SetActive(true);

            Perdiste = true;

            Ganaste = false;

            Invoke("CambiarEscenaPorDerrota", tiempoParaReiniciarEscena);
        }
    }

    //El siguiente metodo permite realizar algunas acciones al ser el ganador
    private void Victoria()
    {
        if (NumVictorias >= 2 && NumVictorias > NumDerrotas && !Ganaste)
        {
            Manitos[3].SetActive(true);
            Ganaste = true;
            Perdiste = false;
            Invoke("CambiarEscenaPorVictoria", tiempoParaReiniciarEscena);
            ContadorEnemigosDerrotados();
        }
    }

    //los siguientes codigos son contadores
    public void ContadorDerrotas()
    {
        finalCombate.finLucha = true;

        inicioCombate.EnLucha = false;

        NumDerrotas++;

        Invoke("ReiniciarEscenaPorDerrotas", tiempoParaReiniciarEscena);
    }

    public void ContadorVictorias()
    {
        NumVictorias++;

        finalCombate.finLucha = true;

        inicioCombate.EnLucha = false;

        Invoke("ReiniciarEscenaPorVictorias", tiempoParaReiniciarEscena);
    }

    private void ContadorEnemigosDerrotados()
    {
        NumEnemigosDerrotados++;
    }

    //Los siguientes metodos cambian escenas dependiendo de los resultados del combate
    private void ReiniciarEscenaPorVictorias()
    {
        if (Ganaste ==  false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reinicia la escena de combates
        }
    }


    private void ReiniciarEscenaPorDerrotas()
    {
        if (Perdiste == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reinicia la escena de combates
        }
    }

    private void CambiarEscenaPorVictoria()
    {
        if (NumEnemigosDerrotados < 11)
        {
            SceneManager.LoadScene(5); //cambia a la escena de transicion de victoria
        }
        else if (NumEnemigosDerrotados == 11)
        {
            SceneManager.LoadScene(11); //cambia a la escena final para mostrar los finales del personaje con el que se juega el combate final
        }
        
    }

    private void CambiarEscenaPorDerrota()
    {
        SceneManager.LoadScene(4); //cambia a la escena de transicion de derrota
    }



    




}
