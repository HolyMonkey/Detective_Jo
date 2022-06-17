using UnityEngine;

public class AtPlayerLooker : MonoBehaviour
{
    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        transform.LookAt(_player.transform);    
    }
}
