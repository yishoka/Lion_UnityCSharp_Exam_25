using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrack : MonoBehaviour
{
    private Transform target;
    public float speed = 0.5f;

    private void Track()
    {
        Vector3 posTarget = target.position;
        Vector3 posBox = transform.position;

        posBox = Vector3.Lerp(posBox, posTarget, 0.5f * Time.deltaTime * speed);

        transform.position = posBox;
    }

    private void Start()
    {
        target = GameObject.Find("Target").transform;
    }

    private void LateUpdate()
    {
        Track();
    }
}
