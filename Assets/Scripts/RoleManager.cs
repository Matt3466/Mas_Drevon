using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class RoleManager : MonoBehaviour
{
    public static RoleManager Instance { get => _instance; }
    public GameObject potentiometerParent;
    public Canvas canvas;

    private static RoleManager _instance;
    private List<Role> roles;
    private List<Potentiometer> potentiometers;

    private void Awake()
    {
        #region Singleton Pattern
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
            Destroy(this.gameObject);
        #endregion

        roles = new List<Role>();

        //Loading Roles
        foreach(Role role in Resources.LoadAll<Role>("Roles"))
        {
            roles.Add(role);
        }

        roles.Shuffle();

        potentiometers = new List<Potentiometer>();
        //Loading potentiometers
        foreach(Potentiometer potentiometer in potentiometerParent.GetComponentsInChildren<Potentiometer>())
        {
            potentiometers.Add(potentiometer);
        }
    }

    private void Start()
    {
        DealRoles();
    }

    public void DrawRole(Potentiometer potMter)
    {
        Role tempRole = potMter.Role;
        potMter.Role = roles[0];
        roles.RemoveAt(0);
        if(tempRole != null)
        {
            roles.Add(tempRole);
            roles.Shuffle();
        }
    }

    public void DealRoles()
    {
        RecoverRoles();

        for (int i = 0; i < potentiometers.Count; i++)
        {
            DrawRole(potentiometers[i]);
        }
    }

    public void RecoverRoles()
    {
        for(int i = 0; i < potentiometers.Count; i++)
        {
            if(potentiometers[i].Role != null)
                roles.Add(potentiometers[i].Role);

            potentiometers[i].Role = null;
        }
    }

}
