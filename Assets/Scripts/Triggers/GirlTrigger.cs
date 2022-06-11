using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlTrigger : TriggerBehaviour
{
    [SerializeField] private Transform _lookAtPoint;
    [SerializeField] private VoiceLineHandler _voiceLineHandler;
    [SerializeField] private float _lookDuration;

    private bool _isTriggered;

    private VoiceLines _voiceLines = new VoiceLines(new GirlVoiceLines());

    public override void OnTriggerActivation(Player player)
    {
        if (_isTriggered)
            return;

        StartCoroutine(Delay(player.loupe, _lookDuration));
        player.loupe.Disable();
        player.cameraHandler.LookAt(_lookAtPoint, _lookDuration, Excuse);
        player.playerMover.StopMoving(_lookDuration);

        _isTriggered = true;
    }

    private void Excuse()
    {
        _voiceLineHandler.CreateVoiceLine(_voiceLines);
    }

    private IEnumerator Delay(Loupe loupe, float time)
    {
        yield return new WaitForSeconds(time);

        loupe.Enable();
    }
}
