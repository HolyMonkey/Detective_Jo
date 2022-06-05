using UnityEngine;

[RequireComponent(typeof(PlayerMover))]

public class PlayerInput : MonoBehaviour
{
    private PlayerMover _payerMover;
    private CameraShaker _shaker;

    private void Start()
    {
        _payerMover = GetComponent<PlayerMover>();
        _shaker = GetComponentInChildren<CameraShaker>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _payerMover.Move();
            _shaker.Begin();
        }
        else
        {
            _shaker.End();
        }
    }
}
