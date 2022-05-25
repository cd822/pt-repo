using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultShape : MonoBehaviour
{

    private Vector3 startPos;
    private Vector3 stopPos;

    void Start()
    {
        startPos = transform.position;
        stopPos = transform.position;
    }

    void Update()
    {
        MoveObject();
    }

    protected virtual void MoveObject()
    {
        Vector3 newPos = Vector3.Lerp(
            startPos,
            startPos + Vector3.up * 2,
            Mathf.PingPong(Time.time, 1)
        );

        transform.position = newPos;
    }

    private void OnMouseDown()
    {
        PrintShape();
    }

    protected virtual void PrintShape()
    {
        Debug.Log("DefaultShape");
    }
}