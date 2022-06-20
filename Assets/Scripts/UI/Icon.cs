using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Icon : MonoBehaviour
{
    [SerializeField] private Image _clueImage;
    [SerializeField] private Color _startColor;
    [SerializeField] private float _colorChangeDuration;
    [SerializeField] private GameObject _particles;

    private void Start()
    {
        _clueImage.DOColor(_startColor, 0);
    }

    public void SetSprite(Sprite sprite)
    {
        _clueImage.sprite = sprite;
    }

    public void ChangeColor()
    {
        _clueImage.DOColor(new Color(1, 1, 1), _colorChangeDuration);
        _particles.SetActive(true);
    }
}
