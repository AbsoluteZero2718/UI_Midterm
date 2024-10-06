using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bounce : MonoBehaviour
{
    public GameObject slime;
    private float duration = 2.0f, elasticity = 5.0f;
    public Vector3 punch;
    private int vibrate = 2;

    public void BounceObject()
    {
        slime.transform.DOPunchPosition(punch, duration, vibrate, elasticity);
    }
}
