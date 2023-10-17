using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 0 - English						en
// 1 - Russian						ru

public class Language : MonoBehaviour
{
    public static int LanguageNumber = 1;
    private string[,] _textPreviesStatic = new string[100, 2];
    public static string[] TextStatic = new string[100];
    private string _langChange;

    private void Awake()
    {
        SetLanguage();
    }

    public void SetLanguage()

    {
        _textPreviesStatic[0, 0] = "No nest";
        _textPreviesStatic[0, 1] = "Нет гнезда";

        _textPreviesStatic[1, 0] = "Jackdaws";
        _textPreviesStatic[1, 1] = "Галки";

        _textPreviesStatic[2, 0] = "Jays";
        _textPreviesStatic[2, 1] = "Сойки";

        _textPreviesStatic[3, 0] = "Sparrows";
        _textPreviesStatic[3, 1] = "Воробьи";

        _textPreviesStatic[4, 0] = "Eagles";
        _textPreviesStatic[4, 1] = "Орлы";

        _textPreviesStatic[5, 0] = "Seagulls";
        _textPreviesStatic[5, 1] = "Чайки";

        _textPreviesStatic[6, 0] = "Owls";
        _textPreviesStatic[6, 1] = "Совы";

        _textPreviesStatic[7, 0] = "Crows";
        _textPreviesStatic[7, 1] = "Вороны";

        _textPreviesStatic[8, 0] = "Phoenixes";
        _textPreviesStatic[8, 1] = "Фениксы";

        _textPreviesStatic[9, 0] = "";
        _textPreviesStatic[9, 1] = "";

        _textPreviesStatic[10, 0] = "";
        _textPreviesStatic[10, 1] = "";

        _textPreviesStatic[11, 0] = "Hawk";
        _textPreviesStatic[11, 1] = "Ястреб";

        _textPreviesStatic[12, 0] = "Seagull";
        _textPreviesStatic[12, 1] = "Чайка";

        _textPreviesStatic[13, 0] = "Owl";
        _textPreviesStatic[13, 1] = "Совух";

        _textPreviesStatic[14, 0] = "Crow";
        _textPreviesStatic[14, 1] = "Ворон";


        for (int x = 0; x < 100; x++) TextStatic[x] = _textPreviesStatic[x, LanguageNumber];
    }
}
