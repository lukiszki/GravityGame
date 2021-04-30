using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    public float GravityConst = 667;
    
    [Range(0.5f, 50)]
    public float Scale = 1;
    
    [Range(0.5f, 20)]
    [SerializeField] private float timeScale = 1;

    private void Update()
    {
        Time.timeScale = timeScale;
    }
}
