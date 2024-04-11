using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acciones : MonoBehaviour
{
    [HideInInspector] public bool agachado;
    [HideInInspector] public bool enPiso;
    private Animator animator;
    private Rigidbody2D rigidbody2D;
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private float distanciaSuelo;
    public InicioCombate inicioCombate;
    public LayerMask capaSuelo;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        enPiso = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo, capaSuelo);
        animator.SetBool("Salto", !enPiso);


    }

   


    //El siguiente metodo permite el salto del jugador
    public void Salto()
    {
        

        if (!agachado && enPiso && !AtaqueController.instance.ataquePlayer && inicioCombate.EnLucha)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            animator.SetBool("Caminar", false);
        }

        animator.SetBool("TransicionAtaqueSalto", !enPiso);
    }

    //El siguiente metodo permite agacharse y levantarse
    public void Agacharse()
    {
        if (!AtaqueController.instance.ataqueAgachado && enPiso && !AtaqueController.instance.ataquePlayer && inicioCombate.EnLucha)
        {
            animator.SetBool("Caminar", false);
            agachado = true;
        }
    }

    public void Levantarse()
    {
        if (!AtaqueController.instance.ataqueAgachado && enPiso && !AtaqueController.instance.ataquePlayer && agachado)
        {
            animator.SetBool("Agachado", false);
            agachado = false;
        }
    }

   

    
}
