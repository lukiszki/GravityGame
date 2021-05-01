using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SolarInfo
{
   #region Velocitis
   public static Vector3 sunVelocity = new Vector3(0,0,0);
   public static Vector3 mercuryVelocity = new Vector3(600,0,0);
   public static Vector3 venusVelocity = new Vector3(500,0,0);
   public static Vector3 earthVelocity = new Vector3(420,0,0);
   public static Vector3 marsVelocity = new Vector3(350,0,0);
   public static Vector3 jupiterVelocity = new Vector3(210,0,0);
   public static Vector3 saturnVelocity = new Vector3(170,0,0);
   public static Vector3 uranusVelocity = new Vector3(150,0,0);
   public static Vector3 neptunVelocity = new Vector3(130,0,0);
   #endregion
   #region Masses

   public static float sunMass = 1989000;
   public static float mercuryMass = 0.3285f;
   public static float venusMass = 4.867f;
   public static float earthMass = 5.972f;
   public static float marsMass = 0.639f;
   public static float jupiterMass = 1890;
   public static float saturnMass = 568.3f;
   public static float uranusMass = 86.81f;
   public static float neptunMass = 102.4f;

   #endregion

}
