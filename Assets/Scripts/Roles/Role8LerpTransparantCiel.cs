using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role8LerpTransparantCiel : PotentiometerConnect
{    //Material Plane = (Material)Resources.Load("NoirMat", typeof(Material));
    public Material Plane;
    public Material Ciel;



    //public float LerpTransparant = 1f;

    public override void SetRangeValue(float range)
    {
        Ciel.SetFloat("Vector1_39c2fb7dfec644579e6d779c2ecd328a", range);
        Plane.SetFloat("Vector1_7a69228fbe514d9ebc7f4480fddeee54", range); //LerpTransparant
    }
}
