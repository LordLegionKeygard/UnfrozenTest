using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllHeroSlots : MonoBehaviour
{
    [SerializeField] private List<Heroes> _heroesList;
    [SerializeField] private Heroes _currentSelectHero;
    [SerializeField] private HeroSlot[] _heroSlots;

    public Heroes CurrentHeroSlotSleect() => _currentSelectHero;

    private void Start()
    {
        CustomEvents.OnSelectHero += SetCurrentSelectHero;
        CustomEvents.OnCompleteMission += UnlockNewHero;
    }

    public bool IsHaveThisHero(Heroes hero)
    {
        for (int i = 0; i < _heroesList.Count; i++)
        {
            if (hero == _heroesList[i]) return true;
        }
        return false;
    }

    private void UnlockNewHero(MissionInfo missionInfo)
    {
        for (int i = 0; i < missionInfo.UnlockHeroes.Length; i++)
        {
            var newHero = missionInfo.UnlockHeroes[i];
            if (!IsHaveThisHero(newHero))
            {
                _heroesList.Add(newHero);
                ActivateNewHero(newHero);
                return;
            }
        }
    }

    private void ActivateNewHero(Heroes Hero)
    {
        for (int i = 0; i < _heroSlots.Length; i++)
        {
            if (!_heroSlots[i].gameObject.activeInHierarchy)
            {
                _heroSlots[i].gameObject.SetActive(true);
                _heroSlots[i].SetNewHero(Hero);
                return;
            }
        }
    }

    private void SetCurrentSelectHero(Heroes hero) => _currentSelectHero = hero;

    private void OnDestroy()
    {
        CustomEvents.OnSelectHero -= SetCurrentSelectHero;
        CustomEvents.OnCompleteMission -= UnlockNewHero;
    }
}
