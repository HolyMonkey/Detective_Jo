using UnityEngine;
using System.Collections;

public class Loupe : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private const string Move = "Move";
    private const string Get = "Get";

    private void Awake()
    {
        Enable();
    }

    public void Disable(bool isEnabledLoupe = true)
    {
        StartCoroutine(Disabling(isEnabledLoupe));
    }

    public void Enable()
    {
        gameObject.SetActive(true);
        _animator.Play(Get);
    }

    private IEnumerator Disabling(bool isEnabledLoupe)
    {
        _animator.Play(Move);

        yield return new WaitForSeconds(1f);

        gameObject.SetActive(isEnabledLoupe);
    }
}
