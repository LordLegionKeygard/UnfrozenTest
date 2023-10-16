using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllHeroSlots : MonoBehaviour
{
    [SerializeField] private Heroes _currentSelectHero;

    public Heroes CurrentHeroSlotSleect() => _currentSelectHero;

    private void Start()
    {
        CustomEvents.OnSelectHero += SetCurrentSelectHero;
    }

    private void SetCurrentSelectHero(Heroes hero) => _currentSelectHero = hero;

    private void OnDestroy()
    {
        CustomEvents.OnSelectHero -= SetCurrentSelectHero;
    }
}
