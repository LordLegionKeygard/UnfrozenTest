using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSlot : MonoBehaviour
{
    [SerializeField] private Heroes _hero;
    public Heroes Hero => _hero;
    private HeroSlotView _heroSlotView;

    private void Awake()
    {
        _heroSlotView = GetComponent<HeroSlotView>();
    }

    public void SetNewHero(Heroes hero)
    {
        _hero = hero;
        _heroSlotView.SetNewName();
    }

    public void SelectSlot()
    {
        CustomEvents.FireSelectHero(_hero);
    }
}
