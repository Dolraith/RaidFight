using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicBoss : _BossInterface {
    [SerializeField]
    private float health = 100f;

    public override void TakeDamage(float damage)
    {
        health = health - damage;
        if (health <= 0)
        {
            Debug.Log("YOU WIN");
            GetComponent<Image>().color = Color.red;
        }
    }

    public override void LinkUIBox(RectTransform uiBox)
    {
        //throw new NotImplementedException();
    }
}
