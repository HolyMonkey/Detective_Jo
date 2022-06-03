using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TriggerBehaviour : MonoBehaviour, ITriggerBehaviour
{
    public abstract void OnTriggerActivation();
}
