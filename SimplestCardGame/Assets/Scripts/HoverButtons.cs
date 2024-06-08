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
        // �������� ��������� Image ������
        buttonImage = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // ��������� �������: ������ ����������� �� hoverImage
        buttonImage.sprite = hoverImage;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // �������� �������: ������ ����������� �� normalImage
        buttonImage.sprite = normalImage;
    }
}
