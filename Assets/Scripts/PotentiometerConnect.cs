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
