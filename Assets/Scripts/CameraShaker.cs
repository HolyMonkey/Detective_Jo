using DG.Tweening;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    [SerializeField] private float _yOffset;
    [SerializeField] private float _duration;

    private Tweener _tween;

    public void Begin()
    {
        if(_tween == null)
        {
            _tween = transform.DOLocalMoveY(_yOffset, _duration).SetLoops(-1, LoopType.Yoyo);
        }
    }

    public void End()
    {
        if(_tween != null)
        {
            _tween = transform.DOLocalMoveY(0, _duration);
        }
    }
}
