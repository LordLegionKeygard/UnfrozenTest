using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMissionPanelSlot : MonoBehaviour
{
    [HideInInspector] public BaseMissionPanelSlotView MissionSlotView;
    [HideInInspector] public MissionInfo CurrentMissionInfo;

    private void Awake()
    {
        MissionSlotView = GetComponent<BaseMissionPanelSlotView>();
    }

    public virtual void SetMissionInfo(MissionInfo missionInfo)
    {
        CurrentMissionInfo = missionInfo;
    }
}
