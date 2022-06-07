using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VoiceLineView : MonoBehaviour
{
    [SerializeField] private TMP_Text _lineView;
    [SerializeField] private Image _background;
    [SerializeField] private float _time;

    public void Init(string line)
    {
        _lineView.text = $"{line}";

        StartCoroutine(Fade(_lineView));
    }

    private IEnumerator Fade(TMP_Text text)
    {
        float changeSpeed = 1 / _time;

        while (text.color.a < 1)
        {
            Color color = new Color(text.color.r, text.color.g, text.color.b, 0);
            color.a = Mathf.MoveTowards(color.a, 1, changeSpeed * Time.deltaTime);
            text.color = color;

            yield return null;
        }

        yield return new WaitForSeconds(1f);

        while (text.color.a > 0)
        {
            Color color = new Color(text.color.r, text.color.g, text.color.b, text.color.a);
            color.a = Mathf.MoveTowards(color.a, 0, changeSpeed * Time.deltaTime);
            text.color = color;

            yield return null;
        }
    }
}
