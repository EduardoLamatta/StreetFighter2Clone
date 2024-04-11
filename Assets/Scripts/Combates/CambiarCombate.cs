using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarCombate : MonoBehaviour
{
    [SerializeField] private float tiempoParaSiguienteCombate;

    [SerializeField] private float tiempoParaFadeOut;

    public GameObject ObjectFadeOut;

    void Update()
    {
        if (ResultadoPartidas.Ganaste)
        {
            Invoke("CambiarSiguienteCombate", tiempoParaSiguienteCombate);

            Invoke("ActivarFadeOut", tiempoParaFadeOut);
        }
    }

    private void CambiarSiguienteCombate()
    {
        SceneManager.LoadScene(3);
    }
 
    private void ActivarFadeOut()
    {
        ObjectFadeOut.SetActive(true); 
    }

}
