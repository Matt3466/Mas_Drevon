using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role7LerpLerp : PotentiometerConnect
{    //Material Plane = (Material)Resources.Load("NoirMat", typeof(Material));
    public Material Plane;
    //public float LerpLerp = 1f;
    public override void SetRangeValue(float range)
    {
        Plane.SetFloat("Vector1_2", range);//LerpLerp
    }

}
