using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickUpAnimation
{
    public void Evaluate(Transform selfTransfrom, Vector3 targetPosition, float speed);
}
