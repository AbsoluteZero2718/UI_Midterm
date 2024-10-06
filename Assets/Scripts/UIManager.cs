using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    //Shake

    public GameObject slime;
    private float duration = 3.0f, strength = 3.0f, randomness = 3.0f;
    private int vibrate = 10;

    public void ShakeObject()
    {
        slime.transform.DOShakePosition(duration, strength, vibrate, randomness);
    }

  
}
