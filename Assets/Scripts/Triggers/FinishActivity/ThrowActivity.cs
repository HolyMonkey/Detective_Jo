using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowActivity : FinishActivity
{
    public override void Prepare(Player player, Suspect suspect)
    {
        player.pickableThrower.Init(suspect, player.pickableHolder);
    }
}
