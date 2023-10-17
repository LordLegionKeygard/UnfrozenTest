using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroSlotView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _heroNameText;
    [SerializeField] private TextMeshProUGUI _heroScoreText;
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
        CustomEvents.OnUpdateHeroScoresView += UpdateScore;
        UpdateScore();
    }

    private void UpdateScore()
    {
        _heroScoreText.text = ScoreSystem.Instance.GetHeroScore(_heroSlot.Hero).ToString();
    }

    public void SetNewName()
    {
        _heroNameText.text = Language.TextStatic[10 + (int)_heroSlot.Hero];
    }

    public void ImageChangeColor(Heroes hero)
    {
        _slotImage.color = (_heroSlot.Hero == hero) ? Color.yellow : Color.gray;
    }

    private void OnDestroy()
    {
        CustomEvents.OnSelectHero -= ImageChangeColor;
        CustomEvents.OnUpdateHeroScoresView -= UpdateScore;
    }
}
