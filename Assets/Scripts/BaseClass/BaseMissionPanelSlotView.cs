using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaseMissionPanelSlotView : MonoBehaviour
{
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI InfoText;

    public virtual void SetText(MissionInfo missionInfo)
    {
        NameText.text = missionInfo.Name;
        InfoText.text = missionInfo.PrehistoryText;
    }
}
