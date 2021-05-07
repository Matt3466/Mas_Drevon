using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class PotentiometerConnect : MonoBehaviour
{
    /// <summary>
    /// Define the actual value of the potentiometer to the connected object, and told it to change its behavior accordingly.
    /// </summary>
    /// <param name="range">The actual range of the potentiometer. Must be between 0 and 1.</param>
    public abstract void SetRangeValue(float range);
}

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