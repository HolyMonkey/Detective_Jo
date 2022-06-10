using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickableCounter : MonoBehaviour
{
    private int _counter;
    private Pickable[] _pickables;
    private SpawnPositions _positions;

    public int pickableCount => _pickables.Length;
    public int playerPickable => _counter;

    private void Awake()
    {
        _pickables = FindObjectsOfType<Pickable>();
        _positions = FindObjectOfType<SpawnPositions>();
    }

    private void OnEnable()
    {
        foreach (var pickable in _pickables)
        {
            pickable.PickedUp += OnPickedUp;
        }

        OnPickedUp();

        ShowIcons(_pickables);
    }

    private void OnDisable()
    {
        foreach (var pickable in _pickables)
        {
            pickable.PickedUp -= OnPickedUp;
        }
    }

    private void OnPickedUp()
    {
        int counter = 0;

        foreach (var pickable in _pickables)
        {
            if (pickable.IsPickedUp)
                counter++;
        }

        _counter = counter;
    }

    private void ShowIcons(Pickable[] pickables)
    {
        int positionNumber = 0;

        foreach (var pickable in pickables)
        {
            Icon icon = Instantiate(pickable.icon, _positions.points[0 + positionNumber].transform);
            pickable.ChangeIcon(icon);
            positionNumber++;
        }
    }
}
