using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceLines
{
    private SuspectVoiceLines _voiceLines;

    public VoiceLines(SuspectVoiceLines voiceLines) => _voiceLines = voiceLines;

    public string GetRandomVoiceLine()
    {
        var index = Random.Range(0, _voiceLines.VoiceLines.Count);

        return _voiceLines.VoiceLines[index];
    }
}    
