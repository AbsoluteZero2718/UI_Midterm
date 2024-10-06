using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlipObject : MonoBehaviour
{
    public GameObject slime;
    private float duration = 1.0f;
    public Vector3 direction;

    public void Flip()
    {
        slime.transform.DORotate(direction, duration, RotateMode.LocalAxisAdd);
    }
}
