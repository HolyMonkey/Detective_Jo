using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceLineHandler : MonoBehaviour
{
    [SerializeField] private VoiceLineView _lineView;

    public void CreateVoiceLine(VoiceLines suspectVoicLines)
    {
        var lineView = Instantiate(_lineView, transform);

        lineView.Init(suspectVoicLines.GetRandomVoiceLine());
    }
}
