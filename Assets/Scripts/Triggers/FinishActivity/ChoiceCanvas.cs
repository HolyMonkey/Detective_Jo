using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChoiceCanvas : MonoBehaviour
{
    [SerializeField] private Button _openButton;
    [SerializeField] private Button _goAwayButton;
    [SerializeField] private TMP_Text _choosView;
    [SerializeField] private AnimationCurve _animationCurve;
    [SerializeField] private float _animationTime;

    private int _startOffset => Screen.height/2;

    public void Init()
    {
        gameObject.SetActive(true);
        StartCoroutine(Animating(_openButton.transform,0));
        StartCoroutine(Animating(_goAwayButton.transform,0.2f));
        StartCoroutine(Delay());
    }

    private IEnumerator Animating(Transform transform, float delay)
    {
        Vector2 startPos = new Vector3(transform.localPosition.x, transform.localPosition.y - _startOffset);
        transform.localPosition = startPos;

        yield return new WaitForSeconds(delay);

        float elapsedTime = 0;

        while (elapsedTime < _animationTime)
        {
            transform.localPosition = new Vector2(transform.localPosition.x, startPos.y + _animationCurve.Evaluate(elapsedTime / _animationTime) * _startOffset);

            elapsedTime += Time.deltaTime;

            yield return null;
        }
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);

        _choosView.gameObject.SetActive(true);
    }
}
