using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role5LerpVoronoVSPolygon : PotentiometerConnect
{

    //Material Plane = (Material)Resources.Load("NoirMat", typeof(Material));
    public Material Plane;
   // private float LerpVoronoVSPolygon = 1;

    public override void SetRangeValue(float range)
    {
        Plane.SetFloat("Vector1_a7fdcc8ed89e4d0eabc04d5e00552952", range);//LerpVoronoVSPolygon
    }
}

