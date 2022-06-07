using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : TriggerBehaviour
{
    [SerializeField] private Animator _animator;

    private const string Start = "Start";

    public override void OnTriggerActivation(Player player)
    {
        _animator.SetTrigger(Start);
    }
}
