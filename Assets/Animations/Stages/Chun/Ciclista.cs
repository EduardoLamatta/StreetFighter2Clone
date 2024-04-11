using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclista : MonoBehaviour
{
    public Rigidbody2D rbdStageRyu;
    [SerializeField] private float Speed;
    [SerializeField] private float posMax;
    [SerializeField] private float posMin;
    void Start()
    {
        rbdStageRyu = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (transform.position.x > posMax) 
        {
            transform.Translate(new Vector3(posMin, 0, 0));
        }
    }
    void FixedUpdate()
    {
        rbdStageRyu.velocity = Vector2.right*Speed;
    } 

}
