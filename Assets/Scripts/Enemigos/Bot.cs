using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    private Rigidbody2D rigidbodyEnemy;
    [SerializeField] private float movx;
    [SerializeField] private float speed;
    [SerializeField] private float fuerzaSalto;
    private Animator animator;
    public InicioCombate inicioCombate;
    public Acciones acciones;
    public VidaJugador vidaJugador;

    //variables usadas para la IA del bot
    private bool playerDetectado;
    public RangoGolpe rangoGolpe;

    //public GameObject player;
    void Start()
    {
        rigidbodyEnemy = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Movimiento();

        if (AtaqueController.instance.ataqueBot || rangoGolpe.rangoGolpe || vidaJugador.cantidadVida <= 0)
        {
            ImpedirMov();
        }
    }

    //El siguiente metodo proporciona el movimietno del bot y hace que siempre mire al jugador
    private void Movimiento()
    {
        rigidbodyEnemy.velocity = new Vector2(movx * speed, rigidbodyEnemy.velocity.y);

        if (acciones.enPiso && !acciones.agachado && !AtaqueController.instance.ataqueBot && playerDetectado && inicioCombate.EnLucha && !rangoGolpe.rangoGolpe)
        {
            animator.SetBool("Caminar", true);

            Vector3 direction = GameObject.FindWithTag("Player").transform.position - transform.position;
            if (direction.x < 0.0f)
            {
                transform.localScale = new Vector3(-1.3f, 1.3f, 1);
                rigidbodyEnemy.velocity = new Vector2(-speed, 0f);
                
            }
            else
            {
                transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
                rigidbodyEnemy.velocity = new Vector2(speed, 0f);
            }
        }

    }

    //El siguiente metodo impide el movimiento del bot
    private void ImpedirMov()
    {
        movx = 0;
        rigidbodyEnemy.velocity = Vector3.zero;
        animator.SetBool("Caminar", false);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerDetectado = true;
        }

       
    }

    

}
