using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VoiceLineView : MonoBehaviour
{
    [SerializeField] private TMP_Text _voiceLineView;
    [SerializeField] private Image _background;
    [SerializeField] private float _time;

    public void Init(string line)
    {
        _voiceLineView.text = $"{line}";

        StartCoroutine(Fade(_background));
        StartCoroutine(Fade(_voiceLineView));
        StartCoroutine(FloatAway());
    }

    private IEnumerator Fade(TMP_Text text)
    {
        float changeSpeed = 1 / _time;

        while (text.color.a > 0)
        {
            Color color = new Color(text.color.r, text.color.g, text.color.b, text.color.a);
            color.a = Mathf.MoveTowards(color.a, 0, changeSpeed * Time.deltaTime);
            text.color = color;

            yield return null;
        }

        Destroy(gameObject);
    }

    private IEnumerator Fade(Image image)
    {
        float changeSpeed = 1 / _time;

        while (image.color.a > 0)
        {
            Color color = new Color(image.color.r, image.color.g, image.color.b, image.color.a);
            color.a = Mathf.MoveTowards(color.a, 0, changeSpeed * Time.deltaTime);
            image.color = color;

            yield return null;
        }
    }

    private IEnumerator FloatAway()
    {
        float changeSpeed = 0.5f / _time;

        while (true)
        {
            transform.position += transform.up * changeSpeed * Time.deltaTime;

            yield return null;
        }
    }
}
