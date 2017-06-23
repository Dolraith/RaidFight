using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleControl : MonoBehaviour {
    [SerializeField]
    private List<_HeroInterface> party;
    [SerializeField]
    private _MapInterface map;
    [SerializeField]
    private _BossInterface boss;

    //To be moved out to the pre-battle UI deciding it is ready.
    private void Start()
    {
        Init();
    }

    /// <summary>
    /// Initialize the class
    /// </summary>
    public void Init () {
        GetSettings();
        SpawnMap();
        SpawnBoss();
        SpawnHeroes();

        BeginFight();
	}

    private void BeginFight()
    {

    }

    private void GetSettings()
    {

    }

    private void SpawnBoss()
    {
        boss = Instantiate(boss) as _BossInterface;
        boss.transform.SetParent(map.transform);
        boss.GetComponent<RectTransform>().position = map.GetBossSpawnPoints(1)[0].position;
    }

    private void SpawnHeroes()
    {
        List<RectTransform> positions = map.GetHeroSpawnPoints(party.Count);
        for(int i = 0; i < party.Count; i++)
        {
            party[i] = Instantiate(party[i]) as _HeroInterface;
            party[i].transform.SetParent(map.transform);
            party[i].GetComponent<RectTransform>().position = positions[i].position;
        }
    }

    private void SpawnMap()
    {

    }
}
