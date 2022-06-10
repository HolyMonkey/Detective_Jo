using System.Collections.Generic;
using UnityEngine;

public class SpawnPositions : MonoBehaviour
{

    [SerializeField] private List<Transform> _points;

    public List<Transform> points => _points;
}
