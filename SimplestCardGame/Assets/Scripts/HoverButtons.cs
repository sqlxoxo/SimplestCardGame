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
        // Получаем компонент Image кнопки
        buttonImage = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Наведение курсора: меняем изображение на hoverImage
        buttonImage.sprite = hoverImage;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Убирание курсора: меняем изображение на normalImage
        buttonImage.sprite = normalImage;
    }
}
