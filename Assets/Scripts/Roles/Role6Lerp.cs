using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role6Lerp : PotentiometerConnect
{

    //Material Plane = (Material)Resources.Load("NoirMat", typeof(Material));
    public Material Plane;
    //public float Lerp = 1f;
    public float ModuloVoronoi = 1;
    public override void SetRangeValue(float range)
    {
        Plane.SetFloat("Vector1_8f2a722eae654c6da32763b310cf1455", range); //Lerp
        Plane.SetFloat("Vector1_9bbade2c50084f879c29c9896bf7ef6d", 2 * ModuloVoronoi * range - ModuloVoronoi);//ModuloVoronoi
    }
}
