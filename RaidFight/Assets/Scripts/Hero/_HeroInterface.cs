using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _HeroInterface : MonoBehaviour {
    public string CharName;
    public Sprite CharPortrait;
    public float DPS;

    public _BossInterface target;
    public float health = 100;
    public float moveSpeed = 5;
    public float actSpeed = 1; //time, in seconds, between actions.

    public abstract void PickTarget();
    public abstract void TimeTick();

    public abstract void Move();
    public abstract void Init();
}
