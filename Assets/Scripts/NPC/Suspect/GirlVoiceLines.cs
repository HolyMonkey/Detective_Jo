using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlVoiceLines : SuspectVoiceLines
{
    private List<string> _girlVoiceLines = new List<string>()
    {
        "I'm alone here!",
        "It's not what you think!!",
    };

    public GirlVoiceLines()
    {
        _voiceLines = _girlVoiceLines;
    }
}
