using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSolarInfo : MonoBehaviour
{
  public void SetMass(int n)
  {
    switch (n)
    {
      case 1 :
        SolarInfo.sunMass = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 2 :
        SolarInfo.mercuryMass = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 3 :
        SolarInfo.venusMass = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 4 :
        SolarInfo.earthMass = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 5 :
        SolarInfo.marsMass = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 6 :
        SolarInfo.jupiterMass = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 7 :
        SolarInfo.saturnMass = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 8 :
        SolarInfo.uranusMass = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 9 :
        SolarInfo.neptunMass = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
    }
  }

  public void SetVelocityX(int n)
  {
    switch (n)
    {
      case 1 :
        SolarInfo.sunVelocity.x = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 2 :
        SolarInfo.mercuryVelocity.x = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 3 :
        SolarInfo.venusVelocity.x =float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 4 :
        SolarInfo.earthVelocity.x = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 5 :
        SolarInfo.marsVelocity.x = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 6 :
        SolarInfo.jupiterVelocity.x = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 7 :
        SolarInfo.saturnVelocity.x = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 8 :
        SolarInfo.uranusVelocity.x = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 9 :
        SolarInfo.neptunVelocity.x = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
    }
  }
  public void SetVelocityY(int n)
  {
    switch (n)
    {
      case 1 :
        SolarInfo.sunVelocity.y = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 2 :
        SolarInfo.mercuryVelocity.y = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 3 :
        SolarInfo.venusVelocity.y =float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 4 :
        SolarInfo.earthVelocity.y = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 5 :
        SolarInfo.marsVelocity.y = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 6 :
        SolarInfo.jupiterVelocity.y = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 7 :
        SolarInfo.saturnVelocity.y = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 8 :
        SolarInfo.uranusVelocity.y = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 9 :
        SolarInfo.neptunVelocity.y = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
    }
  }
  public void SetVelocityZ(int n)
  {
    switch (n)
    {
      case 1 :
        SolarInfo.sunVelocity.z = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 2 :
        SolarInfo.mercuryVelocity.z = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 3 :
        SolarInfo.venusVelocity.z =float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 4 :
        SolarInfo.earthVelocity.z = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 5 :
        SolarInfo.marsVelocity.z = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 6 :
        SolarInfo.jupiterVelocity.z = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 7 :
        SolarInfo.saturnVelocity.z = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 8 :
        SolarInfo.uranusVelocity.z = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
      case 9 :
        SolarInfo.neptunVelocity.z = float.Parse(this.gameObject.GetComponent<Text>().text);
        break;
    }
  }
}
