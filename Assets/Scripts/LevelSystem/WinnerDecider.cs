using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerDecider : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private GameObject[] _screensToClose;

    private int _counter;

    public event Action Victory;

    private void Awake()
    {
        if (_winScreen.activeInHierarchy)
            _winScreen.SetActive(false);
    }

    public void OnMonsterDied(int bossCount)
    {
        _counter++;

        if (_counter >= bossCount)
            SetVictory();
    }

    private void SetVictory()
    {
        StartCoroutine(DelayedEnable());

        Victory?.Invoke();
    }

    private IEnumerator DelayedEnable()
    {
        yield return new WaitForSeconds(1f);

        _winScreen.SetActive(true);

        foreach (var screen in _screensToClose)
        {
            screen.SetActive(false);
        }
    }

    public void OnPlayerLost(string lostCouse)
    {
        foreach (var screen in _screensToClose)
        {
            screen.SetActive(false);
        }
    }
}
