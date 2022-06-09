using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PickableThrower _pickableThrower;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private CameraShaker _cameraShaker;
    [SerializeField] private CameraMover _cameraMover;
    [SerializeField] private PickUpZone _pickUpZone;
    [SerializeField] private Loupe _loupe;
    [SerializeField] private HandAnimator _handAnimator;
    [SerializeField] private PlayerMover _playerMover;

    private PickableHolder _pickableHolder = new PickableHolder();

    public Loupe loupe => _loupe;
    public CameraMover cameraMover => _cameraMover;
    public CameraShaker cameraShaker => _cameraShaker;
    public PickableHolder pickableHolder => _pickableHolder;
    public PickableThrower pickableThrower => _pickableThrower;
    public PlayerInput playerInput => _playerInput;
    public PickUpZone pickUpZone => _pickUpZone;
    public HandAnimator handAnimator => _handAnimator;
    public PlayerMover playerMover => _playerMover;
}
