using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : TriggerBehaviour
{
    [SerializeField] private Suspect _suspect;

    public override void OnTriggerActivation(Player player)
    {
        player.pickableThrower.Init(_suspect, player.pickableHolder);
        player.playerInput.enabled = false;

        FinishHandler.Instance.OnFinishActivated(player, _suspect);
    }
}
