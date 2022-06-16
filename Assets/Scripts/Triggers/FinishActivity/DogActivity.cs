using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogActivity : FinishActivity
{
    public override void Prepare(Player player, Suspect suspect)
    {
        FinishHandler.Instance.ShowEvidence(player.pickableHolder, FindObjectOfType<PickableCounter>());
    }
}
