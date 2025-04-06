using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public enum RealmState
    {
        ONE, TWO, THREE, FOUR, FIVE
    }

    public RealmState currentRealmState = RealmState.ONE;

    public int collectedOrbs = 0;

    public Dictionary<int, bool> unlockedRealms;

    private void Start()
    {
        unlockedRealms = new Dictionary<int, bool>();

        unlockedRealms.Add(1, true);
        unlockedRealms.Add(2, false);
        unlockedRealms.Add(3, false);
        unlockedRealms.Add(4, false);
        unlockedRealms.Add(5, false);
    }
}
