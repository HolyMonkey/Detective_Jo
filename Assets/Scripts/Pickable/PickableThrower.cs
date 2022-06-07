using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableThrower : MonoBehaviour
{
    [SerializeField] private Transform _firePoint;

    private Suspect _suspect;
    private PickableHolder _pickableHolder;
    private bool _isActive;

    public void Init(Suspect suspect, PickableHolder pickableHolder)
    {
        _suspect = suspect;
        _pickableHolder = pickableHolder;

        _isActive = true;
        gameObject.SetActive(true);
    }

    private void Update()
    {
        if (_isActive == false)
            return;

        if (Input.GetMouseButtonDown(0))
            Throw();
    }

    private void Throw()
    {
        if (_pickableHolder.TryGetClue(out Pickable pickable))
        {
            var throwable = Instantiate(pickable.throwable, _firePoint.position, Quaternion.identity);
            throwable.Throw(_suspect.headPoint.position);
        }
    }
}
