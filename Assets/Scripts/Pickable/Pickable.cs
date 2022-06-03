using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    [SerializeField] private float _travelTime;
    [SerializeField] private bool _isFlyingToPlayer;
    [SerializeField] private ParabolaFlyAnimator _parabolaFlyAnimator;

    public bool IsPickedUp { get; private set; }

    private PickUpAnimation _pickUpAnimation = new PickUpAnimation(new StraightFlyAnimation());

    public event Action PickedUp;

    public void PickUp()
    {
        if (IsPickedUp == true)
            return;

        IsPickedUp = true;

        if (_isFlyingToPlayer)
            StartCoroutine(_pickUpAnimation.Animating(transform, Camera.main.transform.position-Vector3.up*1.5f, _travelTime, new Action (OnAnimationEnd)));

        _parabolaFlyAnimator.Init(GetMethod(_isFlyingToPlayer));
    }

    private Action GetMethod(bool isFlyingToPlayer)
    {
        if (isFlyingToPlayer)
            return null;

        return OnAnimationEnd;
    }

    private void OnAnimationEnd()
    {
        PickedUp?.Invoke();
        Disable();
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
