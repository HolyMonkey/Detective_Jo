using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PickableThrower _pickableThrower;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private CameraShaker _cameraShaker;

    private PickableHolder _pickableHolder = new PickableHolder();

    public CameraShaker cameraShaker => _cameraShaker;
    public PickableHolder pickableHolder => _pickableHolder;
    public PickableThrower pickableThrower => _pickableThrower;
    public PlayerInput playerInput => _playerInput;
}
