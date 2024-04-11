using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAnimacionAgachado : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AtaqueController.instance.ataqueAgachado = true;
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AtaqueController.instance.ataqueAgachado = false;
    }
}
