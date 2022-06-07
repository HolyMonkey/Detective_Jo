using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishHandler : MonoBehaviour
{
    [SerializeField] private GameObject _guiltyPanel;
    [SerializeField] private GameObject _notEnougProofsPanel;

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
        _suspect = suspect;
        _player = player;
    }

    public void OnSuspecHitted()
    {
        if (_suspect.isDead)
        {
            _guiltyPanel.SetActive(true);

            return;
        }

        if(_player.pickableHolder.count<= 0)
            _notEnougProofsPanel.SetActive(true);
    }

    private IEnumerator DelayedCheck(int pickedUpClues)
    {
        yield return new WaitForSeconds(1f);

        if (pickedUpClues <= 0)
            _notEnougProofsPanel.SetActive(true);
    }
}
