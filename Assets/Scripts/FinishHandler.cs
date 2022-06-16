using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishHandler : MonoBehaviour
{
    [SerializeField] private GameObject _guiltyPanel;
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private GameObject _notEnougProofsPanel;
    [SerializeField] private GameObject _cluesPanel;
    [SerializeField] private GameObject _tapyTapyPanel;
    [SerializeField] private LevelsHandler _levelsHandler;

    private Suspect _suspect;
    private Player _player;

    public static FinishHandler Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void OnFinishActivated(Player player, Suspect suspect)
    {
        StartCoroutine(DelayedCheck(player.pickableHolder.count));
        _cluesPanel.SetActive(false);
        StartCoroutine(DelayingTapyTapy());
        _suspect = suspect;
        _player = player;
    }

    public void ShowEvidence(PickableHolder pickableHolder, PickableCounter pickableCounter)
    {
        bool isGuilty = pickableHolder.count >= pickableCounter.pickableCount;
        StartCoroutine(DelayedResolution(isGuilty));
    }

    public void OnProofShown()
    {
        if (_suspect.IsGuilty)
        {
            ShowGuiltyPanel();

            return;
        }

        if(_player.pickableHolder.count<= 0)
            ShowNotEnoughProofs();
    }

    private void ShowGuiltyPanel()
    {
        _guiltyPanel.SetActive(true);
        _tapyTapyPanel.SetActive(false);
        StartCoroutine(DelayingWinScreen());
    }

    private void ShowNotEnoughProofs()
    {
        _notEnougProofsPanel.SetActive(true);
        _levelsHandler.OnLevelFailed();
        _tapyTapyPanel.SetActive(false);
    }

    private IEnumerator DelayedCheck(int pickedUpClues)
    {
        yield return new WaitForSeconds(1f);

        if (pickedUpClues <= 0)
        {
            ShowNotEnoughProofs();
        }
    }

    private IEnumerator DelayingWinScreen()
    {
        yield return new WaitForSeconds(1.7f);

        
        _winScreen.SetActive(true);
    }

    private IEnumerator DelayingTapyTapy()
    {
        yield return new WaitForSeconds(1f);

        _tapyTapyPanel.SetActive(true);
    }

    private IEnumerator DelayedResolution(bool isGuilty)
    {
        yield return new WaitForSeconds(1f);

        if (isGuilty)
            ShowGuiltyPanel();
        else
            ShowNotEnoughProofs();
    }
}
