using UnityEngine;
using DG.Tweening;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private float _duration;

    public void Transit(Transform moveToPoint, Transform lookAtPoint)
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMove(moveToPoint.position, _duration));
        sequence.Append(transform.DOLookAt(lookAtPoint.position, _duration));
    }
}
