using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeedX;
    [SerializeField] private float _rotationSpeedY;
    [SerializeField] private float _minY;
    [SerializeField] private float _maxY;

    private float _xRotation;
    private float _yRotation;
    private Vector3 _direction;
    private Camera _camera;
    private Rigidbody _rigidBody;

    private const string MouseX = "Mouse X";
    private const string MouseY = "Mouse Y";

    private void Start()
    {
        _camera = GetComponentInChildren<Camera>();
        _rigidBody = GetComponent<Rigidbody>();
        _direction = new Vector3(Input.GetAxis(MouseX), 0, 0);
        _yRotation = 20f;
    }

    public void Move()
    {
        //transform.Translate(_moveSpeed * Time.deltaTime * Vector3.forward);
        _rigidBody.velocity = _direction;
        
        Rotate();
    }

    private void Rotate()
    {
        _xRotation += Input.GetAxis(MouseX) * _rotationSpeedX;
        _yRotation += Input.GetAxis(MouseY) * _rotationSpeedY * -1;
        _yRotation = Mathf.Clamp(_yRotation, _minY, _maxY);

        //transform.Rotate(0, Input.GetAxis(MouseX) * _rotationSpeedX, 0);
        _camera.transform.rotation = Quaternion.Euler(_yRotation, _xRotation, 0);
    }
}
