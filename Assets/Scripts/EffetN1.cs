using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffetN1 : MonoBehaviour
{
    public Material Sol;
    //Material Sol = (Material)Resources.Load("Sol", typeof(Material));
    public Material Ciel;
    public Material Immeubles;

    public float solFlo;
    public float cielFlo;
    public float immeublesFlo;

    void Start()
    {
        Sol.SetFloat("Vector1_069b562a2b53474389bcbf9579fe7c0b", solFlo);
        Ciel.SetFloat("Vector1_39c2fb7dfec644579e6d779c2ecd328a", cielFlo);
        Immeubles.SetFloat("Vector1_b87c2539ab784c8f873dfff172a30393", immeublesFlo);


    }
    private void Update()
    {
        Sol.SetFloat("Vector1_069b562a2b53474389bcbf9579fe7c0b", solFlo);
        Ciel.SetFloat("Vector1_39c2fb7dfec644579e6d779c2ecd328a", cielFlo);
        Immeubles.SetFloat("Vector1_b87c2539ab784c8f873dfff172a30393", immeublesFlo);
    }
}
