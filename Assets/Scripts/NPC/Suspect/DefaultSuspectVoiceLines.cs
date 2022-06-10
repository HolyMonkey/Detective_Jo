using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultSuspectVoiceLines : SuspectVoiceLines
{
    private List<string> _defaultVoiceLines = new List<string>()
    {
        "It wasn't me",
        "I'm innocent",
        "I was catfished",
        "OUCH",
        "It's not mine"
    };

    public DefaultSuspectVoiceLines()
    {
        _voiceLines = _defaultVoiceLines;
    }
}
