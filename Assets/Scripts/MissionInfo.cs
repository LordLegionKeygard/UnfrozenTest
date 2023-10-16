using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Mission", menuName = "Map/Mission")]
public class MissionInfo : ScriptableObject
{
    [Header("Text")]
    public string Name;
    [TextArea(1, 5)] public string BeforeTextInfo;
    [TextArea(1, 5)] public string MainTextInfo;

    [Header("Info")]
    public Vector2 MapPosition;
    public MissionType MissionType;
    public FractionsWrapper[] FractionsWrapper;
    public Heroes[] UnlockHeroes;

    [Header("Scores")]
    public int CurrentHeroScores;
    public ScoreWrapper[] OtherHeroScores;
}

public enum MissionType
{
    Solo = 0,
    Double = 1,
}

public enum Fractions
{
    NoNest = 0,
    Jackdaws = 1, //Галки
    Jays = 2, //Сойки
    Sparrows = 3, //Воробьи
    Eagles = 4, //Орлы
    Seagulls = 5, //Чайки
    Owls = 6, //Совы
    Crows = 7, //Вороны
    Phoenixes = 8, //Фениксы

}

public enum Heroes
{
    None = 0,
    Hawk = 1,
    Seagull = 2,
    Owl = 3,
    Crow = 4,
}

[System.Serializable]
public class ScoreWrapper
{
    public Heroes Hero;
    public int Score;
}

[System.Serializable]
public class FractionsWrapper
{
    public Heroes NeedHeroes;
    public Fractions[] PlayerFractions;
    public Fractions[] EnemyFractions;
}
