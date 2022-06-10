using UnityEngine;

[RequireComponent(typeof(PlayerMover))]

public class PlayerInput : MonoBehaviour
{
    private PlayerMover _payerMover;
    private CameraShaker _shaker;
    private RaycastHandler _raycastHandler;

    private void Start()
    {
        _payerMover = GetComponent<PlayerMover>();
        _shaker = GetComponentInChildren<CameraShaker>();
        _raycastHandler = GetComponentInChildren<RaycastHandler>();
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            _shaker.Begin();

            if (_raycastHandler.TryPickUp())
                _payerMover.StopMoving(0.6f);
        }


        if (Input.GetMouseButtonUp(0))
            _shaker.End();
    }

    private void FixedUpdate()
    {


        if(Input.GetMouseButton(0))
            _payerMover.Move();


    }
}
