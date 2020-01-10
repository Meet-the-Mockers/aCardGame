using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offense_StandardActions : CardBehaviour
{
    private enum Direction { Left, Middle, Right, Everywhere }

    [SerializeField] private Direction _dir;

    /// <summary>
    /// If this is true, attack the tile the Attacker was on when the round STARTED.
    /// </summary>
    [SerializeField] private bool _currentPosition = false;

    /// <summary>
    /// If this is true, attack will be done towards Middle and will be a headshot if it hits!
    /// </summary>
    [SerializeField] private bool _headshot = false;

    public override void Use()
    {
        if (!_currentPosition)
        {
            if (_headshot)
            {
                Debug.Log("Attacking middle, trying for headshot!");
            }
            else
            {
                switch (_dir)
                {
                    case Direction.Left:
                        Debug.Log("Attacking Left!");
                        break;
                    case Direction.Middle:
                        Debug.Log("Attacking Middle!");
                        break;
                    case Direction.Right:
                        Debug.Log("Attacking Right!");
                        break;
                    case Direction.Everywhere:
                        Debug.Log("Attacking Everywhere!");
                        break;
                }
            }
        }
        else
        {
            Debug.Log("Attacking the tile I was/am on!");
        }
    }
}
