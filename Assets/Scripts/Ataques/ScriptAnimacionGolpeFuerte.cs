using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAnimacionGolpeFuerte : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (AtaqueController.instance.ataquePlayer)
        {
            AtaqueController.instance.GolpeF = true;
        }

        if (AtaqueController.instance.ataqueBot)
        {
            AtaqueController.instance.GolpeBotF = true;
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (AtaqueController.instance.ataquePlayer)
        {
            AtaqueController.instance.GolpeF = false;
            AtaqueController.instance.ataquePlayer = false;
        }

        if (AtaqueController.instance.ataqueBot)
        {
            AtaqueController.instance.GolpeBotF = false;
            AtaqueController.instance.ataqueBot = false;
        }
    }
}
