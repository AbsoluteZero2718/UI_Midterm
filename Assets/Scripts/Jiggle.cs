using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Jiggle : MonoBehaviour
{
    public GameObject slime;
    private float duration = 3.0f, strength = 3.0f, randomness = 5.0f;
    private int vibrate = 2;

    public void JiggleObject()
    {
        slime.transform.DOShakeScale(duration, strength, vibrate, randomness);
    }
}
