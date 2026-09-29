using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public BaseAbility[] Abilities;

    private InputSystem_Actions Inputs;

    private BaseAbility Current;

    private void Awake()
    {
        Inputs = new();
    }
    private void OnEnable()
    {
        Inputs.Enable();
        Inputs.Player.Ability1.performed += selectedability1;
        Inputs.Player.Ability2.performed += selectedability2;
        Inputs.Player.Ability3.performed += selectedability3;
        Inputs.Player.Ability4.performed += selectedability4;
        Inputs.Player.Ability5.performed += selectedability5;

        Inputs.Player.Attack.performed += Oncast;
    }

    private void Oncast(InputAction.CallbackContext context)
    {
        if (Current == null) return;

        Current.execute();
        Current = null;
    }

    private void selectedability5(InputAction.CallbackContext context)
    {
        Select(4);
    }

    private void selectedability4(InputAction.CallbackContext context)
    {
        Select(3);
    }

    private void selectedability3(InputAction.CallbackContext context)
    {
        Select(2);
    }

    private void selectedability2(InputAction.CallbackContext context)
    {
        Select(1);
    }

    private void selectedability1(InputAction.CallbackContext context)
    {
        Select(0);
    }


    void Start()
    {

    }

  
    void Update()
    {

    }
    private void OnDisable()
    {

    }
    public void Select(int index)
    {
        Current = Abilities[index];
    }
}