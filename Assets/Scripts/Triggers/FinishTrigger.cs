using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : TriggerBehaviour
{
    [SerializeField] private Suspect _suspect;
    [SerializeField] protected CameraShaker _shaker;

    public override void OnTriggerActivation(Player player)
    {
        _shaker.End();
        player.pickableThrower.Init(_suspect, player.pickableHolder);
        player.playerInput.enabled = false;

        FinishHandler.Instance.OnFinishActivated(player, _suspect);
    }
}
