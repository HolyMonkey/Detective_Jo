using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class ParabolaFlyAnimator : MonoBehaviour
{
    [SerializeField] private AnimationCurve _animationCurve;
    [SerializeField] private float _animationTime;
    [SerializeField] private float _hight;

    public void Init(Action OnAnimationEnd = null)
    {
        StartCoroutine(Animating(OnAnimationEnd));
    }

    private IEnumerator Animating(Action OnAnimationEnd)
    {
        float elapsedTime = 0;

        while(elapsedTime< _animationTime)
        {
            transform.localPosition = new Vector3(0, _animationCurve.Evaluate(elapsedTime/_animationTime) * _hight, 0);

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        if (OnAnimationEnd != null)
            OnAnimationEnd();
    }
}
