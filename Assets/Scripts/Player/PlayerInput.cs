using UnityEngine;

[RequireComponent(typeof(PlayerMover))]

public class PlayerInput : MonoBehaviour
{
    private PlayerMover _payerMover;
    private CameraHandler _handler;
    private RaycastHandler _raycastHandler;

    private void Start()
    {
        _payerMover = GetComponent<PlayerMover>();
        _handler = GetComponentInChildren<CameraHandler>();
        _raycastHandler = GetComponentInChildren<RaycastHandler>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _handler.BeginShake();

            if (_raycastHandler.TryPickUp())
                _payerMover.StopMoving(0.6f);
        }


        if (Input.GetMouseButtonUp(0))
            _handler.EndShake();
    }

    private void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
            _payerMover.Move();
    }
}
