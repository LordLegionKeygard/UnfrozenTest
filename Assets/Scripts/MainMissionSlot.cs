using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMissionSlot : BaseMissionPanelSlot
{
    [SerializeField] private ScoreSystem _scoreSystem;
    public override void SetMissionInfo(MissionInfo missionInfo)
    {
        base.SetMissionInfo(missionInfo);
        MissionSlotView.SetText(missionInfo);
    }

    public void CompleteMission()
    {
        CustomEvents.FireCompleteMission(CurrentMissionInfo);
        _scoreSystem.ChangeScore(CurrentMissionInfo);
        CustomEvents.FireSelectHero(Heroes.None);
        this.gameObject.SetActive(false);
    }
}
