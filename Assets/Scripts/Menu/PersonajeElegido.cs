using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeElegido : MonoBehaviour
{
    public Animator animator;

    public SelectorController selectorController;

    void Start()
    {

        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        AnimacionCuadroElegido();
    }

    //Este metodo permite la animacion del cuadro selector cuando se presiona enter
    public void AnimacionCuadroElegido()
    {

        if (!selectorController.elegido && Input.GetKeyDown(KeyCode.Return))
        {

            animator.SetTrigger("Seleccionado");
        }
    }








}
