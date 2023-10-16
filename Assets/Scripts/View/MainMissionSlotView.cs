using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMissionSlotView : BaseMissionPanelSlotView
{
    [SerializeField] TextMeshProUGUI[] _playerSideTexts;
    [SerializeField] TextMeshProUGUI[] _enemySideTexts;

    public override void SetText(MissionInfo missionInfo)
    {
        base.SetText(missionInfo);
        if (missionInfo.FractionsWrapper[0].NeedHeroes == Heroes.None)
        {
            for (int i = 0; i < missionInfo.FractionsWrapper[0].PlayerFractions.Length; i++)
            {
                _playerSideTexts[i].text = Language.TextStatic[(int)missionInfo.FractionsWrapper[0].PlayerFractions[i]];
            }

            for (int i = 0; i < missionInfo.FractionsWrapper[0].EnemyFractions.Length; i++)
            {
                _enemySideTexts[i].text = Language.TextStatic[(int)missionInfo.FractionsWrapper[0].EnemyFractions[i]];
            }
        }
        else Debug.LogError("TO DO");

    }

    public void MissionComplete()
    {

    }
}
