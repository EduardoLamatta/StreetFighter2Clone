using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip golpeSonido, pushScreen;

    public GameObject FadeOut;

    [SerializeField] private float tiempo;

    [SerializeField] private float TiempoEspera;

    public Animator animator;


    private void Awake() 
    {
        FadeOut.SetActive(false);    
    }
    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
        
        Invoke("golpe", tiempo);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Comenzar();
        }
    }

    //El siguiente metodo cambia la escena después de un cierto tiempo, además de activar el fadeout y sonidos
    public void Comenzar()
    {
        audioSource.PlayOneShot(pushScreen);

        FadeOut.SetActive(true);

        animator.SetTrigger("FadeOut");

        Invoke("CargarEscena", TiempoEspera);
    }

    //Sonido de golpe cuando un oponente golpea al otro en la animacion
    public void golpe()
    {
        audioSource.PlayOneShot(golpeSonido);
    }

    private void CargarEscena() //permite el cambio de escena al menu, en el que se selecionan los peronajes
    {
        SceneManager.LoadScene(2);
    }


}
