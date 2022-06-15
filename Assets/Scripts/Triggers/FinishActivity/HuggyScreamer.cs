using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HuggyScreamer : FinishActivity
{
    [SerializeField] private GameObject _runCanvas;
    [SerializeField] private HuggyAnimator _animator;
    [SerializeField] private Timer _timer;

    public override void Prepare(Player player, Suspect suspect)
    {
        StartCoroutine(Delay());
        _animator.TriggerHuggy(1.3f);
        
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);

        _timer.Init(_animator.TriggerJump);
    }
}
