using UnityEngine;
using DG.Tweening;
using System.Collections;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private float _duration;

    public void Move(Transform moveToPoint, Transform lookAtPoint)
    {
        StartCoroutine(Moving(moveToPoint, lookAtPoint));
    }

    private IEnumerator Moving(Transform moveToPoint, Transform lookAtPoint)
    {
        transform.DOMove(moveToPoint.position, _duration);

        yield return new WaitForSeconds(_duration);

        transform.DOLookAt(lookAtPoint.position, _duration);
    }
}
