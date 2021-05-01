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

    private Vector3 normalScale;
    

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

        if(!(this.gameObject.name == "Sun"))
        this.transform.localScale = Manager.Scale * normalScale;
    }

    private void Start()
    {
        SetValues();
        normalScale = this.transform.localScale;
        Manager = GameObject.Find("GravityManager").GetComponent<GravityManager>();

        G = Manager.GravityConst;
        rb = GetComponent<Rigidbody>();
        rb.velocity = InitialVelocity;
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

    void SetValues()
    {
        switch (this.gameObject.name)
        {
            case "Sun":
                this.gameObject.GetComponent<Rigidbody>().mass = SolarInfo.sunMass;
                InitialVelocity = SolarInfo.sunVelocity;
                break;
            case "Mercury":
                this.gameObject.GetComponent<Rigidbody>().mass = SolarInfo.mercuryMass;
                InitialVelocity = SolarInfo.mercuryVelocity;
                break;
            case "Venus":
                this.gameObject.GetComponent<Rigidbody>().mass = SolarInfo.venusMass;
                InitialVelocity = SolarInfo.venusVelocity;
                break;
            case "Earth":
               this.gameObject.GetComponent<Rigidbody>().mass = SolarInfo.earthMass;
                InitialVelocity = SolarInfo.earthVelocity;
                break;
            case "Mars":
                this.gameObject.GetComponent<Rigidbody>().mass = SolarInfo.sunMass;
                InitialVelocity = SolarInfo.marsVelocity;
                break;
            case "Jupiter":
                this.gameObject.GetComponent<Rigidbody>().mass = SolarInfo.jupiterMass;
                InitialVelocity = SolarInfo.jupiterVelocity;
                break;
            case "Saturn":
                this.gameObject.GetComponent<Rigidbody>().mass = SolarInfo.saturnMass;
                InitialVelocity = SolarInfo.saturnVelocity;
                break;
            case "Uranus":
                this.gameObject.GetComponent<Rigidbody>().mass = SolarInfo.uranusMass;
                InitialVelocity = SolarInfo.uranusVelocity;
                break;
            case "Neptun":
                this.gameObject.GetComponent<Rigidbody>().mass = SolarInfo.neptunMass;
                InitialVelocity = SolarInfo.neptunVelocity;
                break;


                
        }
    }
}
