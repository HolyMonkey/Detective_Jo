using UnityEngine;

[RequireComponent(typeof(PlayerMover))]

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float _moveDelay;

    private PlayerMover _payerMover;
    private CameraShaker _shaker;
    private float _timer;

    private void Start()
    {
        _payerMover = GetComponent<PlayerMover>();
        _shaker = GetComponentInChildren<CameraShaker>();
        _timer = 0;
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.DrawRay(transform.position, Vector3.forward, Color.red);

            _timer += Time.deltaTime;

            if(_timer >= _moveDelay)
            {
                _payerMover.Move();
                _shaker.Begin();
            }
        }
        else
        {
            _shaker.End();
            _timer = 0;
        }
    }
}
