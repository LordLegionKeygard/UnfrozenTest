using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionPrehistoryActivate : MonoBehaviour
{
    [SerializeField] private MissionPrehistorySlot[] _missionPrehistorySlot;

    private void Start()
    {
        CustomEvents.OnSetPrehistoryMissionSlotInfo += ActivePrehistoryPanel;
    }

    private void ActivePrehistoryPanel(MissionInfo missionInfo)
    {
        var slotNumber = (int)missionInfo.MissionPrehistoryPanel;
        _missionPrehistorySlot[slotNumber].gameObject.SetActive(true);
        _missionPrehistorySlot[slotNumber].SetMissionInfo(missionInfo);
    }

    private void OnDestroy()
    {
        CustomEvents.OnSetPrehistoryMissionSlotInfo -= ActivePrehistoryPanel;
    }
}
