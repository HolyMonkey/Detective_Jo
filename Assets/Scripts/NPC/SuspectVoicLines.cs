using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuspectVoicLines
{
    private List<string> _notGuiltyVoiceLines = new List<string>()
    {
        "It's not mine",
        "It wasn't me",
        "i'm innocent ",
        "I was catfishd",
        "Ouch"
    };

    public string GetRandomVoiceLine()
    {
        var index = Random.Range(0, _notGuiltyVoiceLines.Count);
        Debug.Log(_notGuiltyVoiceLines.Count);

        return _notGuiltyVoiceLines[index];
    }
}    
