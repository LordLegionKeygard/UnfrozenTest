using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionPrehistorySlot : BaseMissionPanelSlot
{
    [SerializeField] private MainMissionSlot _mainMissionSlot;
    public override void SetMissionInfo(MissionInfo missionInfo)
    {
        base.SetMissionInfo(missionInfo);
        MissionSlotView.SetText(missionInfo);
    }

    public void StartMission()
    {
        _mainMissionSlot.gameObject.SetActive(true);
        _mainMissionSlot.SetMissionInfo(CurrentMissionInfo);
    }
}
