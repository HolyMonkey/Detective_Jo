using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PickableThrower _pickableThrower;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private CameraHandler _cameraHandler;
    [SerializeField] private CameraMover _cameraMover;
    [SerializeField] private PickUpZone _pickUpZone;
    [SerializeField] private Loupe _loupe;
    [SerializeField] private HandAnimator _handAnimator;
    [SerializeField] private PlayerMover _playerMover;

    private PickableHolder _pickableHolder = new PickableHolder();

    public Loupe loupe => _loupe;
    public CameraMover cameraMover => _cameraMover;
    public CameraHandler cameraHandler => _cameraHandler;
    public PickableHolder pickableHolder => _pickableHolder;
    public PickableThrower pickableThrower => _pickableThrower;
    public PlayerInput playerInput => _playerInput;
    public PickUpZone pickUpZone => _pickUpZone;
    public HandAnimator handAnimator => _handAnimator;
    public PlayerMover playerMover => _playerMover;
}
