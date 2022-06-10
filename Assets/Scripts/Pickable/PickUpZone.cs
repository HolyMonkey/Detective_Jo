using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class PickUpZone : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Pickable _pickable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Pickable pickable) && pickable.IsPickedUp == false)
        {
            _pickable = pickable;
            _player.handAnimator.TriggerGrab();
            _player.playerMover.StopMoving(0.75f);
            _player.cameraHandler.SitDown();
        }
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }

    public void OnPickUp(Pickable pickable = null)
    {
        _pickable.PickUp();
    }
}
