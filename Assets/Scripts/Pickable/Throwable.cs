using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _forceValue;
    [SerializeField] private BoxCollider _boxCollider;

    private bool _isUsed;

    private void OnCollisionEnter(Collision collision)
    {
        if (_isUsed)
            return;

        if (collision.collider.TryGetComponent(out Suspect suspect))
            OnHit(suspect);
    }

    public void Throw (Vector3 destination)
    {
        gameObject.SetActive(true);

        _boxCollider.isTrigger = false;

        _rigidbody.isKinematic = false;

        Vector3 direction = (destination - transform.position).normalized;

        _rigidbody.AddForce(direction * _forceValue, ForceMode.VelocityChange);
    }

    private void OnHit(Suspect suspect)
    {
        suspect.TakeDamage();

        _isUsed = true;
    }

    private IEnumerator DelayedDisapear()
    {
        yield return new WaitForSeconds(1f);

        gameObject.SetActive(false);
    }
}
