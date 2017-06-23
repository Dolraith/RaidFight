using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _BossInterface : MonoBehaviour {
    public abstract void TakeDamage(float damage);
    public abstract void LinkUIBox(RectTransform uiBox);
}
