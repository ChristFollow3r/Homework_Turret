using System;
using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using Vector3 = UnityEngine.Vector3;

public class TurretMovement : MonoBehaviour
{
    [SerializeField] private GameObject support;
    [SerializeField] private GameObject barrel;
    [SerializeField] private GameObject un;
    [SerializeField] private float supportSens;

    private InputSystem_Actions input;

    private void Awake()
    {
        input = new InputSystem_Actions();
        input.Enable();
    }

    void Update()
    {
        SupportMovement();
    }

    void SupportMovement()
    {
        Vector3 direction = Mouse.current.delta.value;
        
        support.transform.eulerAngles += new Vector3(0, direction.x * supportSens, 0);
    }
}
