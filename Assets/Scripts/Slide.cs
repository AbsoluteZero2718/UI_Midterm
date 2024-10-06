using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Slide : MonoBehaviour
{
    public GameObject slime;
    public float duration;
    public Vector3 to;

    public void Sliding()
    {

        slime.transform.DOMove(to, duration).SetLoops(2, LoopType.Yoyo);

    }
 
}
