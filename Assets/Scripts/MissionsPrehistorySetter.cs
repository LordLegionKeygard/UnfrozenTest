using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionsPrehistorySetter : MonoBehaviour
{
    [SerializeField] private MissionPrehistorySlot[] _missionPrehistorySlot;

    private void Start()
    {
        CustomEvents.OnSetPrehistoryMissionSlotInfo += ActivePrehistoryPanel;
    }

    private void ActivePrehistoryPanel(MissionInfo missionInfo)
    {
        if(missionInfo.MissionType == MissionType.Solo) _missionPrehistorySlot[1].gameObject.SetActive(false);
        var slotNumber = (int)missionInfo.MissionPrehistoryPanel;
        _missionPrehistorySlot[slotNumber].gameObject.SetActive(true);
        _missionPrehistorySlot[slotNumber].SetMissionInfo(missionInfo);
    }

    public void DeactivatePanels()
    {
        _missionPrehistorySlot[0].gameObject.SetActive(false);
        _missionPrehistorySlot[1].gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        CustomEvents.OnSetPrehistoryMissionSlotInfo -= ActivePrehistoryPanel;
    }
}
