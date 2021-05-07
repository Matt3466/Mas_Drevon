using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role3LerpVoronoiVSGradientNoiseSol : PotentiometerConnect
{

    public Material Plane;
    public Material Sol;

    //public float solFlo;
    //private float LerpVoronoiVSGradientNoise = 1;


    public override void SetRangeValue(float range)
    {
        Sol.SetFloat("Vector1_069b562a2b53474389bcbf9579fe7c0b", range);
        Plane.SetFloat("Vector1_fee1a354e2eb4aeba990541d192f2ea1", range);//LerpVoronoiVSGradientNoise
    }

}
