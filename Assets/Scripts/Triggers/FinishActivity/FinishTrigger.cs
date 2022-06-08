using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : TriggerBehaviour
{
    [SerializeField] private Suspect _suspect;
    [SerializeField] private FinishActivity _finishActivity;
    [SerializeField] private Transform _moveToPoint;
    [SerializeField] private Transform _lookAtPoint;

    public override void OnTriggerActivation(Player player)
    {
        player.cameraShaker.End();
        player.cameraMover.Move(_moveToPoint, _lookAtPoint);
        _finishActivity.Prepare(player, _suspect);
        player.playerInput.enabled = false;
        player.loupe.Disable();

        FinishHandler.Instance.OnFinishActivated(player, _suspect);
    }
}
