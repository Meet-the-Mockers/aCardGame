using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense_StandardActions : CardBehaviour
{
    private enum DefendAction { MoveLeft, MoveRight, Crouch, DoNothing, Swap, JumpTo }

    [SerializeField] private DefendAction _action;

    public override void Use()
    {
        switch (_action)
        {
            case DefendAction.MoveLeft:
                Debug.Log("Moving left!");
                break;
            case DefendAction.MoveRight:
                Debug.Log("Moving right!");
                break;
            case DefendAction.Crouch:
                Debug.Log("Crouch!");
                break;
            case DefendAction.DoNothing:
                Debug.Log("Doing nothing!");
                break;
            case DefendAction.Swap:
                Debug.Log("Swapping!");
                break;
            case DefendAction.JumpTo:
                Debug.Log("Jumping!");
                break;
        }
    }
}
