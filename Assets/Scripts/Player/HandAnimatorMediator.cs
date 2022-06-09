using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimatorMediator : MonoBehaviour
{
    [SerializeField] private PickUpZone _pickUpZone;

    private void OnPickUp()
    {
        _pickUpZone.OnPickUp();
    }
}
