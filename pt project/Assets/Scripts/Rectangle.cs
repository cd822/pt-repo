using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : DefaultShape
{
    [SerializeField] private float rotationSpeed = 350f;

    protected override void ChangeObject()
    {
        Debug.Log("Rectangle");
    }

    protected override void MoveObject()
    {
        transform.Rotate(Vector3.left, Time.deltaTime * rotationSpeed);
    }
}