using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicHero: _HeroInterface {
    public float range = 1;

    private float curTime = 0;
    private Vector3 targetPosition;

    private float animationStep = 0f;
    public override void Init()
    {
        animationStep = moveSpeed / actSpeed;
    }

    public override void PickTarget()
    {
        //TODO: Handle more than 1 target here.
        target = GameObject.FindObjectOfType<_BossInterface>();
        transform.up = transform.position - target.transform.position;
    }

    public override void TimeTick()
    {
        if(curTime > 0)
        {
            curTime = curTime - Time.deltaTime;
            return;
        }

        curTime = actSpeed;

        PickTarget();
        if (_MapInterface.Instance.GetDistance(GetComponent<RectTransform>(), target.GetComponent<RectTransform>()) > range)
        {
            Move();
        }
        else
        {
            target.TakeDamage(DPS);
        }
    }

    public override void Move()
    {
        targetPosition = _MapInterface.Instance.MoveTowards(GetComponent<RectTransform>(), target.GetComponent<RectTransform>(), moveSpeed);
        //transform.position = _MapInterface.Instance.MoveTowards(GetComponent<RectTransform>(), target.GetComponent<RectTransform>(), moveSpeed);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, animationStep * Time.deltaTime);
    }
}
