using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickableCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _counterView;

    private int _counter;
    private Pickable[] _pickables;

    public int pickableCount => _pickables.Length;
    public int playerPickable => _counter;

    private void Awake()
    {
        _pickables = FindObjectsOfType<Pickable>();

        foreach (var pickable in _pickables)
        {
            pickable.Here();
        }
    }

    private void OnEnable()
    {
        foreach (var pickable in _pickables)
        {
            pickable.PickedUp += OnPickedUp;
        }

        OnPickedUp();
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

        _counterView.text = $"{counter}/{_pickables.Length}";
    }
}
