using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image backgroundImage;
    public Sprite normalSprite;
    public Sprite hoverSprite;

    public void OnPointerEnter(PointerEventData eventData) {
        backgroundImage.sprite = hoverSprite;
    }

    public void OnPointerExit(PointerEventData eventData) {
        backgroundImage.sprite = normalSprite;
    }
}

