using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role2RadialShearStrenghtYScaleGradientNoise : PotentiometerConnect
{


    public Material Plane;

    private float RadialShearStrenghtY = 100f;
    private float ScaleGradientNoise = 10;

    public override void SetRangeValue(float range)
    {
        Plane.SetFloat("Vector1_1", 2 * RadialShearStrenghtY * range - RadialShearStrenghtY);//RadialShearStrenghtY
        Plane.SetFloat("Vector1_e012f4558e9d4079bec2b197440a2cc8", 2 * ScaleGradientNoise * range - ScaleGradientNoise);//ScaleGradientNoise
    }


}
