using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuggyTrigger : TriggerBehaviour
{
    [SerializeField] private FinishActivity _finishActivity;
    [SerializeField] private Suspect _suspect;

    public override void OnTriggerActivation(Player player)
    {
        player.playerMover.StopMoving(99, true);
        player.cameraHandler.Disable();
        _finishActivity.Prepare(player, _suspect);
    }
}
