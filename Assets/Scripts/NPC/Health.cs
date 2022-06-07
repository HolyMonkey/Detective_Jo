using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Health
{
    private int _maxValue;
    private DeathHandler _deathHandler;
    private int _curentValue;

    public Health(int maxValue, DeathHandler deathHandler)
    {
        _maxValue = maxValue;
        _curentValue = _maxValue;
        _deathHandler = deathHandler;
    }

    public void Decrease(int value)
    {
        _curentValue -= value;

        if (_curentValue <= 0)
            _deathHandler.Die();
    }
}
