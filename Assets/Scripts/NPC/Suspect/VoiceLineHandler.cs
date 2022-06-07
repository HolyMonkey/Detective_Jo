using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceLineHandler : MonoBehaviour
{
    [SerializeField] private VoiceLineView _lineView;

    private SuspectVoicLines _suspectVoiceLines = new SuspectVoicLines();

    public void CreateVoiceLine()
    {
        var lineView = Instantiate(_lineView, transform);

        lineView.Init(_suspectVoiceLines.GetRandomVoiceLine());
    }
}
