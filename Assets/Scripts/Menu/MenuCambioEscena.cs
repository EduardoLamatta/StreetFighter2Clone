using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCambioEscena : MonoBehaviour
{
    public SelectorController selectorController;

    [SerializeField] private float tiempoTransicionInicio;

    [SerializeField] private float tiempoParaFadeOut;

    public GameObject ObjectFadeOut;

    void Update()
    {
        //Si se escogi� un personaje se cambia a la escena con un peque�o retraso, acompa�ado de un fadeout
        if (selectorController.elegido)
        {
            Invoke("CambioEscena", tiempoTransicionInicio);
            Invoke("ActivarFadeOut", tiempoParaFadeOut);
        }
    }

    //El siguiente metodo cambia a la escena 3: "Transici�n de Inicio de combate"
    private void CambioEscena()
    {
        SceneManager.LoadScene(3);
    }

    private void ActivarFadeOut()
    {
        ObjectFadeOut.SetActive(true); 
    }









}
