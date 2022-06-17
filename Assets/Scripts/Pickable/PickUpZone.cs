using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class PickUpZone : MonoBehaviour
{
    [SerializeField] private Player _player;

    private float _pickUpTime = 1.3f;    
    private Pickable _pickable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Pickable pickable) && pickable.IsPickedUp == false)
        {
            _pickable = pickable;
            _player.handAnimator.TriggerGrab();
            _player.playerMover.StopMoving(_pickUpTime);
            _player.cameraHandler.SitDown();
            StartCoroutine(Delaying());
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

    private IEnumerator Delaying()
    {
        _player.loupe.Disable();

        yield return new WaitForSeconds(_pickUpTime-0.3f);

        _player.loupe.Enable();
    }
}
