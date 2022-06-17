using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    [SerializeField] private Throwable _throwable;
    [SerializeField] private float _travelTime;
    [SerializeField] private bool _isFlyingToPlayer;
    [SerializeField] private ParabolaFlyAnimator _parabolaFlyAnimator;
    [SerializeField] private Icon _icon;
    [SerializeField] private GameObject _loupeIcon;

    public bool IsPickedUp { get; set; }
    public Throwable throwable => _throwable;
    public Icon icon => _icon;

    private PickUpAnimation _pickUpAnimation = new PickUpAnimation(new StraightFlyAnimation());

    public event Action PickedUp;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PickUpZone _))
            _loupeIcon.gameObject.SetActive(false);
    }

    public void PickUp()
    {
        _icon.ChangeColor();

        if (IsPickedUp == true)
            return;

        IsPickedUp = true;

        if (_isFlyingToPlayer)
            StartCoroutine(_pickUpAnimation.Animating(transform, Camera.main.transform.position-Vector3.up*3f, _travelTime, new Action (OnAnimationEnd)));

        _parabolaFlyAnimator.Init(GetMethod(_isFlyingToPlayer));
    }

    public void ChangeIcon(Icon icon)
    {
        _icon = icon;
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
        var player = FindObjectOfType<Player>();

        player.pickableHolder.AddClue(this);

        Disable();
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
