using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role1RadialShearStrenghtXStep : PotentiometerConnect
{
    private float RadialShearStrenghtX = 100f;
    //private float Step = 1f;

    public Material Plane;

    public override void SetRangeValue(float range)
    {
        Plane.SetFloat("Vector1_03e1689afd0f4b5aad2be6ee336bd9a5", 2 * RadialShearStrenghtX * range - RadialShearStrenghtX); //RadialShearStrenghtX
        Plane.SetFloat("Vector1_528084098f534ea1b2fbeadc2712d101", range);//Step
    }
}

