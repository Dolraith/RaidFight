using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _MapInterface : MonoBehaviour {
    public static _MapInterface Instance
    {
        get
        {
            if (map == null) map = GameObject.FindObjectOfType<_MapInterface>();
            return map;
        }
    }
    private static _MapInterface map = null;

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

    /// <summary>
    /// Gets navigation distance between two points
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public abstract float GetDistance(RectTransform a, RectTransform b);
    public abstract Vector2 MoveTowards(RectTransform from, RectTransform to, float speed);

    /// <summary>
    /// Used by dynamic maps to make things happen (i.e. lava flows / ebbs and such)
    /// </summary>
    public abstract void TimeTick();
}
