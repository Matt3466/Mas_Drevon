using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("PotentiometerConnect/Rot Z")]
public class RotZConnect : PotentiometerConnect
{
    #region Public Field
    [Range(0.1f, 360f)]
    public float rangeRotZ = 180f;
    #endregion

    #region Private Field
    private Vector3 initRot;
    #endregion

    private void Awake()
    {
        initRot = this.transform.rotation.eulerAngles;
    }

    public override void SetRangeValue(float range)
    {
        var value = (initRot.z - rangeRotZ) + (rangeRotZ * 2 * range);

        this.transform.localEulerAngles = 
            new Vector3(
            this.transform.localEulerAngles.x,
            this.transform.localEulerAngles.y,
            value);
    }
}
