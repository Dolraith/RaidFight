using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMap : _MapInterface {
    [SerializeField]
    private List<RectTransform> heroSpawns = null;
    [SerializeField]
    private List<RectTransform> bossSpawns = null;
	// Use this for initialization
	void Start () {
		foreach(RectTransform hero in heroSpawns)
        {
            hero.gameObject.SetActive(false);
        }

        foreach(RectTransform boss in bossSpawns)
        {
            boss.gameObject.SetActive(false);
        }
	}

    public override List<RectTransform> GetBossSpawnPoints(int numSpawns)
    {
        int bossSpawnCount = bossSpawns.Count;
        List<RectTransform> resultList = new List<RectTransform>();
        bool foundLocation = false;

        //Catch the edges
        if (bossSpawns == null)
        {
            Debug.LogError("Can't get boss spawn locations from this map.");
            return null;
        }
        if(numSpawns > bossSpawns.Count)
        {
            Debug.LogError("Too many boss spawn locations required from map. Map doesn't support this many.");
            return null;
        }

        //ok now generate a sublist
        int randIndex;        
        for(int i = 0; i < numSpawns; i++) //get numspawns unique transforms
        {
            foundLocation = false;
            do
            {
                randIndex = Random.Range(0, bossSpawnCount);
                RectTransform curTransform = bossSpawns[randIndex];
                if (!resultList.Contains(curTransform))
                {
                    foundLocation = true;
                    resultList.Add(curTransform);
                }
            } while (foundLocation == false);
        }

        return resultList;

    }
    public override List<RectTransform> GetHeroSpawnPoints(int numSpawns)
    {
        int heroSpawnCount = heroSpawns.Count;
        List<RectTransform> resultList = new List<RectTransform>();
        bool foundLocation = false;

        //Catch the edges
        if (heroSpawns == null)
        {
            Debug.LogError("Can't get hero spawn locations from this map.");
            return null;
        }
        if (numSpawns > heroSpawns.Count)
        {
            Debug.LogError("Too many hero spawn locations required from map. Map doesn't support this many.");
            return null;
        }

        //ok now generate a sublist
        int randIndex;
        for (int i = 0; i < numSpawns; i++) //get numspawns unique transforms
        {
            foundLocation = false;
            do
            {
                randIndex = Random.Range(0, heroSpawnCount);
                RectTransform curTransform = heroSpawns[randIndex];
                if (!resultList.Contains(curTransform))
                {
                    foundLocation = true;
                    resultList.Add(curTransform);
                }
            } while (foundLocation == false);
        }

        return resultList;
    }
}
