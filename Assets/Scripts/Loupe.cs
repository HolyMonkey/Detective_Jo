using UnityEngine;
using System.Collections;

public class Loupe : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private const string Move = "Move";

    public void Disable()
    {
        StartCoroutine(Disabling());
    }

    private IEnumerator Disabling()
    {
        _animator.Play(Move);

        yield return new WaitForSeconds(1f);

        gameObject.SetActive(false);
    }
}
