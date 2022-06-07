using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuspectVoicLines
{
    private List<string> _notGuiltyVoiceLines = new List<string>()
    {
        "This is not mine",
        "I was catfished",
        "i'm innocent "
    };

    public string GetRandomVoiceLine()
    {
        var index = Random.Range(0, _notGuiltyVoiceLines.Count);

        return _notGuiltyVoiceLines[index];
    }
}    
