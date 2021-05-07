using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TypeReferences;
using SolidUtilities;

[CreateAssetMenu()]
public class Role : ScriptableObject
{
    public string roleName;
    [Inherits(typeof(PotentiometerConnect))]
    [SerializeField] public TypeReference connectType;
}
