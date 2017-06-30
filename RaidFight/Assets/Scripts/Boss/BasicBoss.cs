using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicBoss : _BossInterface {
    [SerializeField]
    private float health = 100f;
    private float curHealth = 0;
    private HealthBar healthBar = null;

    public override void Init()
    {
        curHealth = health;
    }

    public override void TakeDamage(float damage)
    {
        curHealth = curHealth - damage;
        if (curHealth <= 0)
        {
            Debug.Log("YOU WIN");
            GetComponent<Image>().color = Color.red;
        }
    }

    public override void LinkUIBox(RectTransform uiBox)
    {
        healthBar = uiBox.GetComponentInChildren<HealthBar>();
        healthBar.SetBossName(GetName());
        healthBar.SetHealthPercent(1);
    }

    public override void TimeTick()
    {
        ///Do boss things here.
        healthBar.SetHealthPercent(curHealth / health);
    }

    public override string GetName()
    {
        return "Bossman";
    }
}
