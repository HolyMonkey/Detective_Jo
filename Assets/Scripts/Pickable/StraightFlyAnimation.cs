using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightFlyAnimation : IPickUpAnimation
{
    public void Evaluate(Transform selfTransfrom, Vector3 targetPosition, float speed)
    {
        selfTransfrom.position = Vector3.MoveTowards(selfTransfrom.position, targetPosition, speed * Time.deltaTime);
    }
}
