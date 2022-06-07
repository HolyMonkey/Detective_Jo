using System.Collections;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeedX;
    [SerializeField] private float _rotationSpeedY;
    [SerializeField] private float _minY;
    [SerializeField] private float _maxY;

    private float _yRotation;
    private Vector3 _targetPosition;
    private Camera _camera;
    private Rigidbody _rigidBody;
    private bool _canMove;

    private const string MouseX = "Mouse X";
    private const string MouseY = "Mouse Y";

    private void Start()
    {
        _yRotation = 50f;
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

    public void StopMoving()
    {
        _canMove = false;

        StartCoroutine(Counting());
    }

    private void Rotate()
    {
        _yRotation += Input.GetAxis(MouseY) * _rotationSpeedY * -1;
        _yRotation = Mathf.Clamp(_yRotation, _minY, _maxY);

        transform.Rotate(0, Input.GetAxis(MouseX) * _rotationSpeedX, 0);
        _camera.transform.localRotation = Quaternion.Euler(_yRotation, 0, 0);
    }

    private IEnumerator Counting()
    {
        yield return new WaitForSeconds(0.1f);

        _canMove = true;
    }
}
