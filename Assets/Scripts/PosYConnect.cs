using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("PotentiometerConnect/Pos Y")]
public class PosYConnect : PotentiometerConnect
{
    #region Public Field
    [Range(0.1f, 20f)]
    public float rangeY = 5f;
    #endregion

    #region Private Field
    private Vector3 initPos;
    #endregion

    private void Awake()
    {
        initPos = this.transform.position;
    }

    public override void SetRangeValue(float range)
    {
        this.transform.position = new Vector3(this.transform.position.x, (initPos.y - rangeY) + (rangeY * 2 * range), this.transform.position.z);
    }
}
