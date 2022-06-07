using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DeathHandler : MonoBehaviour
{
    public bool isDead { get; private protected set; }

    public abstract void Die();
}
