using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionStageRyu : MonoBehaviour
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
        if (transform.position.x < posMin) 
        {
            transform.Translate(new Vector3(posMax, 0, 0));
        }
    }
    void FixedUpdate()
    {
        rbdStageRyu.velocity = Vector2.left*Speed;
    }
}
