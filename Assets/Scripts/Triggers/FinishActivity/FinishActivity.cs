using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FinishActivity : MonoBehaviour
{
    public abstract void Prepare(Player player, Suspect suspect);
}
