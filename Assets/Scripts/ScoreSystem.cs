using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem Instance;
    [SerializeField] private AllHeroSlots _allHeroSlot;
    [SerializeField] private ScoreWrapper[] _scoreWrapper;

    private void Awake()
    {
        if (Instance != null) Debug.LogError("Two or more instance of ScoreSystem");
        else Instance = this;
    }

    public void ChangeScore(MissionInfo missionInfo)
    {
        var newScoreWrapper = missionInfo.OtherHeroScores;

        for (int i = 0; i < _scoreWrapper.Length; i++)
        {
            if (_scoreWrapper[i].Hero == _allHeroSlot.CurrentHeroSlotSleect()) _scoreWrapper[i].Score += missionInfo.CurrentHeroScores;

            for (int k = 0; k < newScoreWrapper.Length; k++)
            {
                if (_scoreWrapper[i].Hero == newScoreWrapper[k].Hero)
                {
                    _scoreWrapper[i].Score += newScoreWrapper[k].Score;
                }
            }
        }
        CustomEvents.FireUpdateHeroScoresView();
    }

    public int GetHeroScore(Heroes hero)
    {
        for (int i = 0; i < _scoreWrapper.Length; i++)
        {
            if (_scoreWrapper[i].Hero == hero) return _scoreWrapper[i].Score;
        }
        Debug.LogError("Score system don't have this hero!");
        return 0;
    }
}


