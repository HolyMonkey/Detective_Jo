using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _countdown;
    [SerializeField] private float _initialValue;
    [SerializeField] private float _timerValue;
    [SerializeField] private bool _showTimer;
    [SerializeField] private GameObject _clueCanvas;


    public void Init(Action OnEnd)
    {
        gameObject.SetActive(true);
        _clueCanvas.SetActive(false);

        if (_showTimer)
            StartCoroutine(Counting());

        _image.gameObject.SetActive(_showTimer);
        _countdown.gameObject.SetActive(_showTimer);

        StartCoroutine(Delay(OnEnd));

    }

    private IEnumerator Counting()
    {
        float viewTime = _initialValue;
        float elapsedTime = 0;
        float valuePerTick = _initialValue/_timerValue;
        _image.fillAmount = 1;

        while (viewTime > 0)
        {
            viewTime -= valuePerTick *Time.deltaTime;

            _countdown.text = $"{(int)viewTime}";
            elapsedTime += Time.deltaTime;
            _image.fillAmount -= 1 / _timerValue * Time.deltaTime;

            viewTime = Mathf.Clamp(viewTime,0, 100);

            if (viewTime < 1f)
            {
                _countdown.text = $"{FormatTime(viewTime)}";
            }

            yield return null;
        }
    }

    private IEnumerator Delay(Action OnEnd)
    {
        yield return new WaitForSeconds(_timerValue);

        OnEnd();
    }

    public string FormatTime(double time)
    {
        TimeSpan ts = TimeSpan.FromSeconds(time);

        return string.Format("{0:00}:{1:00}", ts.Seconds, ts.Milliseconds);
    }
}
