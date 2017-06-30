using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    [SerializeField]
    RectTransform maxHealth;
    [SerializeField]
    RectTransform curHealth;
    [SerializeField]
    Text bossName;

    /// <summary>
    /// Takes percent in the 0-1 format. 
    /// </summary>
    /// <param name="percent"></param>
    public void SetHealthPercent(float percent)
    {
        curHealth.anchorMax = new Vector2(percent, 1f);
        curHealth.offsetMax = Vector2.zero;
    }

    public void SetBossName(string name)
    {
        bossName.text = name;
    }
}
