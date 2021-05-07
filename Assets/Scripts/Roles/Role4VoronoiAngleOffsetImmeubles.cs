using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role4VoronoiAngleOffsetImmeubles : PotentiometerConnect
{
    //Material Plane = (Material)Resources.Load("NoirMat", typeof(Material));
    public Material Plane;
    public Material Immeubles;



    public float VoronoiAngleOffset = 10;
    public override void SetRangeValue(float range)
    {
        Plane.SetFloat("Vector1_203ef2848132419a9d56bb482e52fb91", 2 * VoronoiAngleOffset * range - VoronoiAngleOffset);//VoronoiAngleOffset
        Immeubles.SetFloat("Vector1_b87c2539ab784c8f873dfff172a30393", range);
    }



}
