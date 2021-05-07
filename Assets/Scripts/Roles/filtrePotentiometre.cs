using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filtrePotentiometre : PotentiometerConnect
{
    public Material Plane;
    //Material Plane = (Material)Resources.Load("NoirMat", typeof(Material));
    //Material Sol = (Material)Resources.Load("Sol", typeof(Material));



    private float RadialShearStrenghtX = 100f;
    private float RadialShearStrenghtY = 100f;
    //private float Step = 1f;
    //private float LerpVoronoiVSGradientNoise = 1;
    private float ScaleGradientNoise = 10;
    public float VoronoiAngleOffset = 10;
    public float ModuloVoronoi = 1;
    //public float LerpVoronoVSPolygon = 1;
    //public float Lerp = 1f;
    //public float LerpLerp = 1f;
    //public float LerpTransparant = 1f;
    public float alpha = 0.5f;




    public override void SetRangeValue(float range)
    {
        Plane.SetFloat("Vector1_03e1689afd0f4b5aad2be6ee336bd9a5", 2* RadialShearStrenghtX * range - RadialShearStrenghtX); //RadialShearStrenghtX
        Plane.SetFloat("Vector1_1", 2 * RadialShearStrenghtY * range - RadialShearStrenghtY);//RadialShearStrenghtY
        Plane.SetFloat("Vector1_528084098f534ea1b2fbeadc2712d101",range);//Step
        Plane.SetFloat("Vector1_fee1a354e2eb4aeba990541d192f2ea1", range);//LerpVoronoiVSGradientNoise
        Plane.SetFloat("Vector1_e012f4558e9d4079bec2b197440a2cc8", 2* ScaleGradientNoise* range - ScaleGradientNoise);//ScaleGradientNoise
        Plane.SetFloat("Vector1_203ef2848132419a9d56bb482e52fb91", 2* VoronoiAngleOffset * range - VoronoiAngleOffset);//VoronoiAngleOffset
        Plane.SetFloat("Vector1_9bbade2c50084f879c29c9896bf7ef6d", 2 * ModuloVoronoi * range - ModuloVoronoi);//ModuloVoronoi
        Plane.SetFloat("Vector1_a7fdcc8ed89e4d0eabc04d5e00552952", range);//LerpVoronoVSPolygon
        Plane.SetFloat("Vector1_8f2a722eae654c6da32763b310cf1455", range); //Lerp
        Plane.SetFloat("Vector1_2", range);//LerpLerp
        Plane.SetFloat("Vector1_7a69228fbe514d9ebc7f4480fddeee54", range); //LerpTransparant
        Plane.SetFloat("Vector1_0120db06a0dc41b283c721792904e324", range * alpha); //alpha



    }
}
