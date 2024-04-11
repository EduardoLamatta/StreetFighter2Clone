using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MensajeInicial : MonoBehaviour
{
    public GameObject FadeOut;

    [SerializeField] private float tiempoCambiarEscena;
    void Start() 
    {
        FadeOut.SetActive(false); //Empieza con un FadeIn
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) //Cambia la escena al presionar enter
        {
            FadeOut.SetActive(true); //Cambia la escena con un fadeout

            Invoke("CambioEscena", tiempoCambiarEscena);
        }   
    }  


    private void CambioEscena()  //metodo que cambia la escena hacia la pantalla de introduccion, en la que salen dos personas peleando
    {
        SceneManager.LoadScene(1);
    }



}
