using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuspectDeath : DeathHandler
{
    [SerializeField] private SusAnimator _susAnimator;

    public override void Die()
    {
        _susAnimator.TriggerToGround();
        isDead = true;
    }
}
