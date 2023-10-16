using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSlot : MonoBehaviour
{
    public Heroes Hero;

    public void SelectSlot()
    {
        CustomEvents.FireSelectHero(Hero);
    }
}
