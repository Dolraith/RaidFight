using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _MapInterface : MonoBehaviour {
    //TODO: enable start placement tactics
    /// <summary>
    /// Returns a list of starting locations for the boss. If possible will fill up any locations before duplicating
    /// </summary>
    /// <param name="numSpawns"></param>
    /// <returns></returns>
    public abstract List<RectTransform> GetBossSpawnPoints(int numSpawns);
    /// <summary>
    /// Returns a list of starting locations for the heroes. If possible will fill up any locations before duplicating
    /// </summary>
    /// <param name="numSpawns"></param>
    /// <returns></returns>
    public abstract List<RectTransform> GetHeroSpawnPoints(int numSpawns);
}
