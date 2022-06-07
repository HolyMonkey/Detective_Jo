using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] private SusAnimator _susAnimator;

    private void Trigger()
    {
        _susAnimator.TriggerSus();
    }
}
