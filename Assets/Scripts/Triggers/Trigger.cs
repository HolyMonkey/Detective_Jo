using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Trigger : MonoBehaviour
{
    [SerializeField] private TriggerBehaviour _triggerBehaviour;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
            _triggerBehaviour.OnTriggerActivation();
    }
}
