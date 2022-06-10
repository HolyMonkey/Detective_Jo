using UnityEngine;

public class AlphMaskMover : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Player _player;

    private void Update()
    {
        transform.rotation = _camera.transform.rotation;
        transform.position = _player.loupe.transform.position;
    }
}
