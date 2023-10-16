using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class MissionPrehistoryView : BaseMissionPanelSlotView
{
    [SerializeField] private AllHeroSlots _allHeroSlots;
    [SerializeField] private Button _button;

    private void Start()
    {
        CustomEvents.OnSelectHero += StartMissionButtonToggle;
    }

    private void OnEnable()
    {
        StartMissionButtonToggle(_allHeroSlots.CurrentHeroSlotSleect());
    }

    private void StartMissionButtonToggle(Heroes hero)
    {
        _button.interactable = (hero == Heroes.None) ? false : true;
    }

    private void OnDestroy()
    {
        CustomEvents.OnSelectHero -= StartMissionButtonToggle;
    }
}
