using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Pulse : MonoBehaviour
{
    public GameObject slime;
    private float duration = 2.0f, elasticity = 2.0f;
    public Vector3 punch;
    private int vibrate = 2;

    public void ObjectPulse()
    {
        slime.transform.DOPunchScale(punch, duration, vibrate, elasticity);
    }
}
