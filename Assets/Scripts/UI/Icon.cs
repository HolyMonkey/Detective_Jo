using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Icon : MonoBehaviour
{
    [SerializeField] private Image _clueImage;
    [SerializeField] private float _colorChangeDuration;

    private void Start()
    {
        _clueImage.DOColor(new Color(0, 0, 0), 0);
    }

    public void SetSprite(Sprite sprite)
    {
        _clueImage.sprite = sprite;
    }

    public void ChangeColor()
    {
        _clueImage.DOColor(new Color(1, 1, 1), _colorChangeDuration);
    }
}
