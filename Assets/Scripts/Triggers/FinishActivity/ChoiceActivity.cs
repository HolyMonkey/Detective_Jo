using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceActivity : FinishActivity
{
    [SerializeField] private ChoiceCanvas _choiceCanvas;
    [SerializeField] private GameObject _clueCanvas;

    public override void Prepare(Player player, Suspect suspect)
    {
        _choiceCanvas.Init();
        _clueCanvas.SetActive(false);
    }
}
