using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _counter;

    private Pickable[] _pickables;

    private void Awake()
    {
        _pickables = FindObjectsOfType<Pickable>();
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

        _counter.text = $"{counter}/{_pickables.Length}";
    }
}
