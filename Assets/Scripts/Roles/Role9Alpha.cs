using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role9Alpha : PotentiometerConnect
{    //Material Plane = (Material)Resources.Load("NoirMat", typeof(Material));
    public Material Plane;
    public float alpha = 0.5f;

    public override void SetRangeValue(float range)
    {
        Plane.SetFloat("Vector1_0120db06a0dc41b283c721792904e324", range * alpha); //alpha
    }
}
