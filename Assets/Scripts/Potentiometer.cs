using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using DG.Tweening;
using TypeReferences;

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
            Role.valueRange = range;

            if (range != oldRange && controlledObj != null)
                controlledObj.SetRangeValue(range);
        }
    }
    public SpriteRenderer cursor;
    public float minRotation = 55f;
    public float maxRotation = -240f;

    public PotentiometerConnect controlledObj;
    public InputAction rangeControl;
    public InputAction roleControl;
    [Range(0.001f, 1.000f)]
    public float stepIncrement = 0.05f;
    public int IdPot { get => _idPot; }
    public Text roleText;
    public Role Role
    {
        get => _role;
        set
        {
            _role = value;
            if (this.Role != null)
            {
                Range = _role.valueRange;
                DisplayRole();
                GetControlledObjectParameter();
            }
        }
    }
    #endregion

    #region Private Fields
    private float range = 0.5f;
    private float oldRange;
    private int _idPot = 0;
    private static int lastId;
    private Role _role;
    private Sequence sequence;
    #endregion

    #region Inputs
    private void EnableInputs()
    {
        rangeControl.Enable();
        roleControl.Enable();
    }

    private void DisableInputs()
    {
        rangeControl.Disable();
        roleControl.Disable();
    }
    #endregion

    private void Awake()
    {
        if (roleText == null)
            Debug.LogError("Potentiometer doesn't have a Role display text", this);

        roleControl.performed += ctx => DrawNewRole();

        //Assigner un id unique
        lastId++;
        _idPot = lastId;
    }

    private void Update()
    {
        Range += rangeControl.ReadValue<float>() * stepIncrement;
        if(cursor != null)
            cursor.transform.localEulerAngles = 
                new Vector3(cursor.transform.localEulerAngles.x, cursor.transform.localEulerAngles.y,
                minRotation - 
                (Mathf.Abs(maxRotation) + Mathf.Abs(minRotation)) * this.Range );
    }

    public void DisplayRole()
    {
        if(this.Role != null)
            roleText.text = this.Role.roleName;

        sequence.Kill();
        sequence = DOTween.Sequence();
        sequence.Append(roleText.DOFade(1f, 1.5f));
        sequence.AppendInterval(10f);
        sequence.Append(roleText.DOFade(0f, 1.5f));

    }

    public void DrawNewRole()
    {
        RoleManager.Instance.DrawRole(this);
    }

    public void GetControlledObjectParameter()
    {
        if (this.Role != null)
            controlledObj = (PotentiometerConnect)GameObject.FindObjectOfType(this.Role.connectType.Type);
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
