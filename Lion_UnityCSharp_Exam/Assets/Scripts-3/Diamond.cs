using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    public GameObject cube;

    private void CreateFloor(int w)
    {
        for (int j = 0; j <= w; j++)
        {
            for (int i = 10; i >= j; i--)
            {
                Instantiate(cube, new Vector3(j * 2, (i - 10) * 2, 0), Quaternion.Euler(270, 0, 0));
                Instantiate(cube, new Vector3(j * 2 * -1, (i - 10) * 2 * -1, 0), Quaternion.Euler(270, 0, 0));
            }
            for (int i = 0; i <= Math.Abs(j - 10); i++)
            {
                Instantiate(cube, new Vector3(j * 2, i * 2, 0), Quaternion.Euler(270, 0, 0));
                Instantiate(cube, new Vector3(j * 2 * -1, i * 2 * -1, 0), Quaternion.Euler(270, 0, 0));

            }
        }
    }

    private void Awake()
    {
        CreateFloor(10);
    }
}
