using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    public float GravityConst = 667;
    public float Scale = 1;
    [SerializeField] private float timeScale = 1;

    private void Update()
    {
        Time.timeScale = timeScale;
    }
}
