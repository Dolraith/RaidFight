using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _HeroInterface : MonoBehaviour {
    public string CharName;
    public Sprite CharPortrait;
    public float DPS;

    public _BossInterface target;
    public float health = 100;
}
