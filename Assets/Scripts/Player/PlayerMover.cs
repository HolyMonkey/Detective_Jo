using System.Collections;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeedX;
    [SerializeField] private float _rotationSpeedY;
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;

    private float _cameraPitch;
    private Vector3 _targetPosition;
    private Camera _camera;
    private Rigidbody _rigidBody;
    private bool _canMove;

    private const string MouseX = "Mouse X";
    private const string MouseY = "Mouse Y";

    private void Start()
    {
        _cameraPitch = 45f;
        _camera = GetComponentInChildren<Camera>();
        _rigidBody = GetComponent<Rigidbody>();
        _canMove = true;
    }

    public void Move()
    {
        if (_canMove)
        {
            _targetPosition = transform.position + (transform.forward * _moveSpeed * Time.deltaTime);
            _rigidBody.MovePosition(_targetPosition);

            Rotate();
        }
    }

    public void StopMoving(float timePeriod)
    {
        StartCoroutine(Counting(timePeriod));
    }

    private void Rotate()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis(MouseX), Input.GetAxis(MouseY));

        _cameraPitch -= mouseDelta.y * _rotationSpeedX;
        _cameraPitch = Mathf.Clamp(_cameraPitch, _maxX, _minX);
        _camera.transform.localEulerAngles = Vector3.right * _cameraPitch;

        transform.Rotate(Vector3.up * mouseDelta.x * _rotationSpeedY);
    }

    private IEnumerator Counting(float timePeriod)
    {
        _canMove = false;

        yield return new WaitForSeconds(timePeriod);

        _canMove = true;
    }
}
