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
    private Camera _camera;

    private const string MouseX = "Mouse X";
    private const string MouseY = "Mouse Y";

    private void Start()
    {
        _camera = GetComponentInChildren<Camera>();
    }

    public void Move()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * Vector3.forward);
        
        Rotate();
    }

    private void Rotate()
    {
        _xRotation += Input.GetAxis(MouseX) * _rotationSpeedX;
        _yRotation += Input.GetAxis(MouseY) * _rotationSpeedY * -1;
        _yRotation = Mathf.Clamp(_yRotation, _minY, _maxY);

        transform.Rotate(0, Input.GetAxis(MouseX) * _rotationSpeedX, 0);
        _camera.transform.rotation = Quaternion.Euler(_yRotation, _xRotation, 0);
    }
}
