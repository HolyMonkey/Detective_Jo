using UnityEngine;

[RequireComponent(typeof(PlayerMover))]

public class PlayerInput : MonoBehaviour
{
    private PlayerMover _payerMover;
    private CameraShaker _shaker;
    private RaycastHandler _raycastHandler;
    private float _timer;

    private void Start()
    {
        _payerMover = GetComponent<PlayerMover>();
        _shaker = GetComponentInChildren<CameraShaker>();
        _raycastHandler = GetComponentInChildren<RaycastHandler>();
        _timer = 0;
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _shaker.Begin();

            if (_raycastHandler.TryPickUp())
                _payerMover.StopMoving();
        }

        if(Input.GetMouseButton(0))
            _payerMover.Move();

        if(Input.GetMouseButtonUp(0))
            _shaker.End();
    }
}
