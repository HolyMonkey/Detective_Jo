using System.Collections;
using DG.Tweening;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    [SerializeField] private float _yOffset;
    [SerializeField] private float _duration;

    private Tweener _tween;
    private bool _isWalking;
    private Coroutine _coroutine;

    public void Begin()
    {
        if (_tween != null)
            _tween.Kill();

        _tween = transform.DOLocalMoveY(_yOffset, _duration).SetLoops(-1, LoopType.Yoyo);

        _isWalking = true;
    }

    public void End()
    {
        if (_tween != null)
            _tween.Kill();

        _tween = transform.DOLocalMoveY(0, _duration);

        _isWalking = false;
    }

    public void SitDown()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(SittingDown());
    }

    private IEnumerator SittingDown()
    {
        if (_tween != null)
            _tween.Kill();

        _tween = transform.DOLocalMoveY(-1f, _duration);

        yield return new WaitForSeconds(_duration);

        if (_tween != null)
            _tween.Kill();

        _tween = transform.DOLocalMoveY(0, _duration/2);

        yield return new WaitForSeconds(_duration/2);

        if (_isWalking)
            Begin();
    }
}
