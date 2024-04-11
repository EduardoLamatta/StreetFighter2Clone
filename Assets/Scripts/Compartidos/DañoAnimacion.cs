using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoAnimacion : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void AnimacionDañoEnemigo()
    {
        animator.SetTrigger("DañoCara");
    }


        
}

