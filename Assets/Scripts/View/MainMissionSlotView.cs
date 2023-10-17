using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMissionSlotView : BaseMissionPanelSlotView
{
    [SerializeField] private AllHeroSlots _allHeroSlots;
    [SerializeField] TextMeshProUGUI[] _playerSideTexts;
    [SerializeField] TextMeshProUGUI[] _enemySideTexts;

    public override void SetText(MissionInfo missionInfo)
    {
        ClearFractionText();
        NameText.text = missionInfo.Name;
        InfoText.text = missionInfo.MainText;

        if (missionInfo.FractionsWrapper[0].NeedHeroes == Heroes.None)
        {
            SetFractionsText(missionInfo, 0);
        }
        else
        {
            if (_allHeroSlots.IsHaveThisHero(missionInfo.FractionsWrapper[0].NeedHeroes))
            {
                SetFractionsText(missionInfo, 0);
            }
            else
            {
                SetFractionsText(missionInfo, 1);
            }
        }
    }

    private void SetFractionsText(MissionInfo missionInfo, int number)
    {
        for (int i = 0; i < missionInfo.FractionsWrapper[number].PlayerFractions.Length; i++)
        {
            _playerSideTexts[i].text = Language.TextStatic[(int)missionInfo.FractionsWrapper[number].PlayerFractions[i]];
        }

        for (int i = 0; i < missionInfo.FractionsWrapper[number].EnemyFractions.Length; i++)
        {
            _enemySideTexts[i].text = Language.TextStatic[(int)missionInfo.FractionsWrapper[number].EnemyFractions[i]];
        }
    }

    private void ClearFractionText()
    {
        for (int i = 0; i < _playerSideTexts.Length; i++)
        {
            _playerSideTexts[i].text = string.Empty;
        }

        for (int i = 0; i < _enemySideTexts.Length; i++)
        {
            _enemySideTexts[i].text = string.Empty;
        }
    }
}
