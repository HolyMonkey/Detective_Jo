using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PickUpAnimation
{
    private IPickUpAnimation _animation;

    public PickUpAnimation(IPickUpAnimation animation)
    {
        _animation = animation;
    }

    public IEnumerator Animating(Transform selfTransfrom, Vector3 targetPosition, float travelTime, Action onAnimationEnd = null)
    {
        float distance = Vector3.Distance(targetPosition, selfTransfrom.position);
        float speed = distance / travelTime;

        while(distance > 0.1f)
        {
            _animation.Evaluate(selfTransfrom, targetPosition, speed);

            distance = Vector3.Distance(targetPosition, selfTransfrom.position);

            yield return null;
        }

        if(onAnimationEnd != null)
            onAnimationEnd();
    }
}
