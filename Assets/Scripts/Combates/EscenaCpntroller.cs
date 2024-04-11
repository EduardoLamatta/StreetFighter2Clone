using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscenaCpntroller : MonoBehaviour
{
    //[SerializeField] private float tiempoEspera = 6; 

    public GameObject escenariosPeleas; //Hace referencia a todo lo que conforma el escenario de las peleas

    public InicioCombate inicioCombate;

    [SerializeField] private float tiempoInicioLucha; //Tiempo de  a esperar antes de poder jugar

    void Start()
    {
        AntesDeIniciarPelea();
    }

    //El siguiente metodo se ejecuta antes de iniciar la pelea, se restringe el moviemiento por un momento
    private void AntesDeIniciarPelea()
    {
        inicioCombate.inicioLucha = true; //Hace referencia a que la lucha empezó, pero no se permite mover al jugador

        escenariosPeleas.SetActive(true);

        Invoke("InicioPeleas", tiempoInicioLucha);
    }

    //El siguiente metodo permite Empezar a pelear
    public void InicioPeleas()
    {
        inicioCombate.inicioLucha = false;

        inicioCombate.EnLucha = true;
    }

}
