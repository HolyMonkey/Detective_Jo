using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SusAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private const string Sus = "Sus";
    private const string Hit = "Hit";
    private const string ToGround = "ToGround";

    public void TriggerSus()
    {
        _animator.SetTrigger(Sus);
    }

    public void TriggerHit()
    {
        _animator.ResetTrigger(Hit);
        _animator.SetTrigger(Hit);
    }

    public void TriggerToGround()
    {
        _animator.SetTrigger(ToGround);
    }
}
