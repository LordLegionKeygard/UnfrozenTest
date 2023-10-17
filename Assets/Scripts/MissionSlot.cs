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
        CustomEvents.OnCompleteMission += ChangeMissionState;
    }

    private void SetStartInfo()
    {
        CurrentMissionState = MissionInfo.StartState;
        UpdateSlot();
        _missionView.CheckState(CurrentMissionState);
    }

    private void ChangeMissionState(MissionInfo missionInfo)
    {
        if (MissionInfo == missionInfo)
        {
            CurrentMissionState = MissionState.Passed;
        }
        else
        {
            for (int i = 0; i < missionInfo.NextMissionsId.Length; i++)
            {
                if (MissionInfo.Id == missionInfo.NextMissionsId[i])
                {
                    if(CurrentMissionState != MissionState.Active) CurrentMissionState = missionInfo.NextMissionIdState[i];
                }
            }

            for (int i = 0; i < missionInfo.BlockedMissionsId.Length; i++)
            {
                if (MissionInfo.Id == missionInfo.BlockedMissionsId[i])
                {
                    CurrentMissionState = MissionState.TemporarilyBlocked;
                }
            }
        }
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
        CustomEvents.OnCompleteMission -= ChangeMissionState;
    }
}
