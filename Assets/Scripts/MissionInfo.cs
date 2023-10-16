using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Mission", menuName = "Map/Mission")]
public class MissionInfo : ScriptableObject
{
    [Header("Text")]
    public string Name;
    public string NumberText;
    [TextArea(1, 5)] public string PrehistoryText;
    [TextArea(1, 5)] public string MainText;

    [Header("Info")]
    public int Id;
    public MissionState StartState;
    public Vector2 MapPosition;
    public MissionPrehistoryPanel MissionPrehistoryPanel;
    public FractionsWrapper[] FractionsWrapper;
    public Heroes[] UnlockHeroes;

    [Header("Scores")]
    public int CurrentHeroScores;
    public ScoreWrapper[] OtherHeroScores;
}

public enum MissionPrehistoryPanel
{
    Left = 0,
    Right = 1
}

public enum MissionState
{
    Active = 0,
    Blocked = 1,
    TemporarilyBlocked = 2,
    Passed = 3,
}

public enum Fractions
{
    NoNest = 0,
    Jackdaws = 1,
    Jays = 2,
    Sparrows = 3,
    Eagles = 4,
    Seagulls = 5,
    Owls = 6,
    Crows = 7,
    Phoenixes = 8,

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
