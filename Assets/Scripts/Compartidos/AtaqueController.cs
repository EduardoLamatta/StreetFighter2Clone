using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueController : MonoBehaviour
{
    public static AtaqueController instance;

    [HideInInspector] public bool ataquePlayer;
    [HideInInspector] public bool ataqueSaltar;
    [HideInInspector] public bool ataqueDelante;
    [HideInInspector] public bool ataqueAgachado;

    [HideInInspector] public bool ataqueBot;
    [HideInInspector] public bool ataqueSaltarBot;
    [HideInInspector] public bool ataqueDelanteBot;
    [HideInInspector] public bool ataqueAgachadoBot;
    public bool GolpeL, GolpeM, GolpeF;
    public bool GolpeBotL, GolpeBotM, GolpeBotF;
    void Awake()
    {
        instance = this;
    }

}
