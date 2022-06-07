using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDamagable
{
    public Health health { get; }

    public void TakeDamage();
}
