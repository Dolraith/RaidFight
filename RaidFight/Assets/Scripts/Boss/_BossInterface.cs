using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _BossInterface : MonoBehaviour {
    public abstract void TakeDamage(float damage);
    public abstract void LinkUIBox(RectTransform uiBox);
    public abstract void TimeTick();
    public abstract string GetName();
    public abstract void Init();
}
