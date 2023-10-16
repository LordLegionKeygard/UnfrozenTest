using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMissionSlot : BaseMissionPanelSlot
{
    public override void SetMissionInfo(MissionInfo missionInfo)
    {
        base.SetMissionInfo(missionInfo);
        MissionSlotView.SetText(missionInfo);
    }

    public void StartMission()
    {

    }
}
