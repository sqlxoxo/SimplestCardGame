using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverButtonImageChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite normalImage;
    public Sprite hoverImage;

    private Image buttonImage;

    void Start()
    {

        buttonImage = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

        buttonImage.sprite = hoverImage;
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        buttonImage.sprite = normalImage;
    }
}