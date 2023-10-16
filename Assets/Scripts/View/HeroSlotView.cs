using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroSlotView : MonoBehaviour
{
    private HeroSlot _heroSlot;
    private Image _slotImage;

    private void Awake()
    {
        _heroSlot = GetComponent<HeroSlot>();
        _slotImage = GetComponent<Image>();
    }

    private void Start()
    {
        CustomEvents.OnSelectHero += ImageChangeColor;
    }

    public void ImageChangeColor(Heroes hero)
    {
        _slotImage.color = (_heroSlot.Hero == hero) ? Color.yellow : Color.gray;
    }

    private void OnDestroy()
    {
        CustomEvents.OnSelectHero -= ImageChangeColor;
    }
}
