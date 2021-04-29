using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atractor : MonoBehaviour
{
    Rigidbody rb;
    public static List<Atractor> Atractors;
    
    /// <summary>
    /// GRAWITACJA W EDYTORZE USTAWIONA 10000000000000 WIEKSZA
    /// </summary>
    public float  G = 6.674f;

    private GravityManager Manager;
    

    public Vector3 InitialVelocity = new Vector3(0,0,0);

    private void OnEnable()
    {
        if (Atractors == null)
            Atractors = new List<Atractor>();
        Atractors.Add(this);
        Manager = GameObject.Find("GravityManager").GetComponent<GravityManager>();
    }

    private void OnDestroy()
    {
        Atractors.Remove(this);
    }

    private void FixedUpdate()
    {
        Atractor[] atractors = FindObjectsOfType<Atractor>();
        foreach (Atractor atractor in atractors)
        {
            if(atractor != this)
            Atract(atractor);
        }
    }

    private void Start()
    {
        Manager = GameObject.Find("GravityManager").GetComponent<GravityManager>();

        G = Mathf.Sqrt() Manager.GravityConst;
        rb = GetComponent<Rigidbody>();
        rb.velocity = G*InitialVelocity;
    }

    void Atract(Atractor objToAtract)
    {
        G = Manager.GravityConst;
        Rigidbody rbToAttract = objToAtract.rb;

        Vector3 direction = rb.position - rbToAttract.position;
        
        float distance = direction.magnitude;

        float forceMagnitude = G*(rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude;
        rbToAttract.AddForce(force);

    }
}
