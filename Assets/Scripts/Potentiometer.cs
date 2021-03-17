using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Potentiometer : MonoBehaviour
{
    #region Public Fields
    public float Range
    {
        get { return range; }
        set
        {
            oldRange = range;
            range = value;
            if (range < 0)
                range = 0f;
            else if (range > 1f)
                range = 1f;

            if (range != oldRange)
                controlledObj.SetRangeValue(range);
        }
    }

    public PotentiometerConnect controlledObj;
    public InputAction rangeControl;
    [Range(0.001f, 1.000f)]
    public float stepIncrement = 0.05f;
    #endregion

    #region Private Fields
    private float range = 0.5f;
    private float oldRange;
    #endregion

    #region Inputs
    private void EnableInputs()
    {
        rangeControl.Enable();
    }

    private void DisableInputs()
    {
        rangeControl.Disable();
    }
    #endregion

    private void Awake()
    {
        if (controlledObj == null)
        {
            Debug.LogError("Controlled object assigned does not implement IPotentiometerConnect. Please add a component with this interface.");
            this.enabled = false;
        }
    }

    private void Update()
    {
        Range += rangeControl.ReadValue<float>() * stepIncrement;
    }

    #region Unity Callbacks
    private void OnEnable()
    {
        EnableInputs();
    }

    private void OnDisable()
    {
        DisableInputs();
    }
    #endregion
}
