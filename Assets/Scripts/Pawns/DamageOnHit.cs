using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public float damageAmount;

    private void OnCollisionEnter(Collision collisionTowardsSomething)
    {
        GameObject otherObject = collisionTowardsSomething.gameObject;

        PlayerPawn pawn = otherObject.GetComponent<PlayerPawn>();

        if(pawn != null)
        {
            Health health = pawn.GetComponent<Health>();
        }
    }
}
