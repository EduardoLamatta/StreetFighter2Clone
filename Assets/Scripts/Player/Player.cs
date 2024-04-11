using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbodyPlayer;
    [SerializeField] private float movxPlayer;
    [SerializeField] private float speed;
    private Animator animator;
    public InicioCombate inicioCombate;
    public AtaquesPuños ataquePuños;
    public AtaquePatadas ataquePatadas;
    public PatadasAgachado patadasAgachado;
    public PatadasSaltar patadasSaltar;
    public PuñosAgachado puñosAgachado;
    public PuñosSaltar puñosSaltar;
    public Acciones acciones;

    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        //La siguiente condicion impide al jugador moverse al estar agachado o atacando
        if (inicioCombate.EnLucha)
        {
            if (AtaqueController.instance.ataquePlayer || acciones.agachado)
            {
                ImpedirMov();
            }
        }

        CorrecionAtaqueSalto();

        if (Input.GetKeyDown(KeyCode.W))
        {
            acciones.Salto();
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            acciones.Levantarse();
        }

        if (inicioCombate.EnLucha)
        {
            if (Input.GetKey(KeyCode.S))
            {
                acciones.Agacharse();
                animator.SetBool("Agachado", Input.GetKey(KeyCode.S));
            }

            AtaquesPuñosJugador();
            AtaquesPatadasJugador();
        }

    }



    private void FixedUpdate()
    {
        Movimiento();
        
    }

     
    //El siguiente metodo proporciona el movimietno del jugador y hace que siempre mire al bot
    private void Movimiento()
    {
        Vector3 direction = GameObject.FindWithTag("Enemigo").transform.position - transform.position;
        if (direction.x < 0.0f)
        {
            transform.localScale = new Vector3(-1.3f, 1.3f, 1);

        }
        else
        {
            transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
        }

        if (acciones.enPiso && !acciones.agachado && !AtaqueController.instance.ataquePlayer && inicioCombate.EnLucha)
        {
            movxPlayer = Input.GetAxisRaw("Horizontal");
            animator.SetBool("Caminar", movxPlayer != 0);
            rigidbodyPlayer.velocity = new Vector2(movxPlayer * speed, rigidbodyPlayer.velocity.y);
        }

    }

    

    //El siguiente metodo impide el movimiento
    private void ImpedirMov()
    {
        movxPlayer = 0f;
        rigidbodyPlayer.velocity = Vector3.zero;
        animator.SetBool("Caminar", false);
    }


    

    //El siguiente metodo es una correction en el momento de atacar al saltar
    private void CorrecionAtaqueSalto()
    {
        if (AtaqueController.instance.ataqueSaltar)
        {
            ImpedirMov();
        }

        if (acciones.enPiso)
        {
            AtaqueController.instance.ataqueSaltar = false;
        }
    }

    //El siguiente metodo permite lanzar los golpes a través de los inputs
    private void AtaquesPuñosJugador()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (acciones.agachado)
            {                
                puñosAgachado.PuñosLigero();
            }
            else if (!acciones.enPiso)
            {
                puñosSaltar.PuñosLigero();
            }
            else ataquePuños.PuñoLigero();
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            if (acciones.agachado) puñosAgachado.PuñosMedio();

            else if (!acciones.enPiso) puñosSaltar.PuñosMedio();

            else ataquePuños.PuñoMedio();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            if (acciones.agachado) puñosAgachado.PuñosFuerte();

            else if (!acciones.enPiso) puñosSaltar.PuñosFuerte();

            else ataquePuños.PuñoFuerte();
        }
    }

    private void AtaquesPatadasJugador()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (acciones.agachado) patadasAgachado.PatadaLigera();

            else if (!acciones.enPiso) patadasSaltar.PatadaLigera();

            else ataquePatadas.PatadaLigera();
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            if (acciones.agachado) patadasAgachado.PatadaMedia();

            else if (!acciones.enPiso) patadasSaltar.PatadaMedia();

            else ataquePatadas.PatadaMedia();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            if (acciones.agachado) patadasAgachado.PatadaFuerte();

            else if (!acciones.enPiso) patadasSaltar.PatadaFuerte();

            else ataquePatadas.PatadaFuerte();
        }

    }


}
