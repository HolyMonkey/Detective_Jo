using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : TriggerBehaviour
{
    [SerializeField] private Suspect _suspect;
    [SerializeField] private FinishActivity _finishActivity;

    public override void OnTriggerActivation(Player player)
    {
        player.cameraShaker.End();
        _finishActivity.Prepare(player, _suspect);
        player.playerInput.enabled = false;

        FinishHandler.Instance.OnFinishActivated(player, _suspect);
    }
}
