using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newMoveStateData", menuName = "Data/State Data/Move State")]
// To hold variables of MoveState script as a scriptable object
public class D_MoveState : ScriptableObject
{
    public float movementSpeed = 3f;
}
