using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionSlot : MonoBehaviour
{
    public MissionInfo MissionInfo;
    private MissionView _missionView;
    [SerializeField] private MissionState CurrentMissionState;

    private void Awake()
    {
        _missionView = GetComponent<MissionView>();
        CustomEvents.OnSetStartMissionSlotsInfo += SetStartInfo;
    }

    private void SetStartInfo()
    {
        CurrentMissionState = MissionInfo.StartState;
        UpdateSlot();
        _missionView.CheckState(CurrentMissionState);
    }

    private void UpdateSlot()
    {
        _missionView.UpdateMissionView(MissionInfo);
    }

    public void OpenMission()
    {
        CustomEvents.FireSetPrehistoryMissionSlotInfo(MissionInfo);
    }

    private void OnDestroy()
    {
        CustomEvents.OnSetStartMissionSlotsInfo -= SetStartInfo;
    }
}
