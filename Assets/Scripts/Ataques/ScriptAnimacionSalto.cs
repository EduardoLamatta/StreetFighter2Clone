using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAnimacionSalto : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AtaqueController.instance.ataqueSaltar = true;
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AtaqueController.instance.ataqueSaltar = false;
    }
}
