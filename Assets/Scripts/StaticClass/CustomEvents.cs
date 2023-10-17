using System;
using UnityEngine;

public class CustomEvents
{
    public static event Action OnSetStartMissionSlotsInfo;
    public static void FireSetStartMissionSlotsInfo()
    {
        OnSetStartMissionSlotsInfo?.Invoke();
    }

    public static event Action<MissionInfo> OnSetPrehistoryMissionSlotInfo;
    public static void FireSetPrehistoryMissionSlotInfo(MissionInfo missionInfo)
    {
        OnSetPrehistoryMissionSlotInfo?.Invoke(missionInfo);
    }

    public static event Action<Heroes> OnSelectHero;
    public static void FireSelectHero(Heroes hero)
    {
        OnSelectHero?.Invoke(hero);
    }

    public static event Action<MissionInfo> OnCompleteMission;
    public static void FireCompleteMission(MissionInfo missionInfo)
    {
        OnCompleteMission?.Invoke(missionInfo);
    }

    public static event Action OnUpdateHeroScoresView;
    public static void FireUpdateHeroScoresView()
    {
        OnUpdateHeroScoresView?.Invoke();
    }
}
