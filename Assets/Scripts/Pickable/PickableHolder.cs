using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableHolder
{
    private List<Pickable> _pickables = new List<Pickable>();

    public int count => _pickables.Count;
    
    public void AddClue(Pickable pickable)
    {
        _pickables.Add(pickable);
    }

    public bool TryGetClue(out Pickable pickable)
    {
        pickable = null;

        if (_pickables.Count < 1)
            return false;

        pickable = _pickables[0];
        _pickables.RemoveAt(0);

        return true;
    }
}
