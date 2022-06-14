using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuggyScreamer : FinishActivity
{
    [SerializeField] private GameObject _runCanvas;
    [SerializeField] private Animator _animator;

    public override void Prepare(Player player, Suspect suspect)
    {
        StartCoroutine(Delay());
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);

        _runCanvas.SetActive(true);
    }
}
