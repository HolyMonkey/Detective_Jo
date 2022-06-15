using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuggyAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private const string Screamer = "Screamer";

    private const string Jump = "Jump";

    public void TriggerHuggy(float delay)
    {
        StartCoroutine(Delay(delay));
    }

    public void TriggerJump()
    {
        _animator.SetTrigger(Jump);
    }

    private IEnumerator Delay(float delay)
    {
        yield return new WaitForSeconds(delay);

        _animator.SetTrigger(Screamer);
    }
}
