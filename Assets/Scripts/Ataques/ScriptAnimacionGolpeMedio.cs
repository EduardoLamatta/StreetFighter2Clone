using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAnimacionGolpeMedio : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (AtaqueController.instance.ataquePlayer)
        {
            AtaqueController.instance.GolpeM = true;
        }

        if (AtaqueController.instance.ataqueBot)
        {
            AtaqueController.instance.GolpeBotM = true;
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (AtaqueController.instance.ataquePlayer)
        {
            AtaqueController.instance.GolpeM = false;
            AtaqueController.instance.ataquePlayer = false;
        }

        if (AtaqueController.instance.ataqueBot)
        {
            AtaqueController.instance.GolpeBotM = false;
            AtaqueController.instance.ataqueBot = false;
        }
    }
}
