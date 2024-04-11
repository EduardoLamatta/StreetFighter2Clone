using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAnimacionGolpeLigero : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (AtaqueController.instance.ataquePlayer)
        {
            AtaqueController.instance.GolpeL = true;
        }

        if (AtaqueController.instance.ataqueBot)
        {
            AtaqueController.instance.GolpeBotL = true;
        }

    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (AtaqueController.instance.ataquePlayer)
        {
            AtaqueController.instance.GolpeL = false;
            AtaqueController.instance.ataquePlayer = false;
        }

        if (AtaqueController.instance.ataqueBot)
        {
            AtaqueController.instance.GolpeBotL = false;
            AtaqueController.instance.ataqueBot = false;
        }

        
    }
}
