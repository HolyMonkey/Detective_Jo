using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PickableThrower _pickableThrower;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private CameraShaker _cameraShaker;
    [SerializeField] private CameraMover _cameraMover;
    [SerializeField] private Loupe _loupe;

    private PickableHolder _pickableHolder = new PickableHolder();

    public Loupe loupe => _loupe;
    public CameraMover cameraMover => _cameraMover;
    public CameraShaker cameraShaker => _cameraShaker;
    public PickableHolder pickableHolder => _pickableHolder;
    public PickableThrower pickableThrower => _pickableThrower;
    public PlayerInput playerInput => _playerInput;
}
