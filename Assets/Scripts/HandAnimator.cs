using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private const string Grab = "Grab";

    public void TriggerGrab()
    {
        _animator.SetTrigger(Grab);
    }
}
