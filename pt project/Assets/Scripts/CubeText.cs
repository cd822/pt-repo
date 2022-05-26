using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeText : MonoBehaviour
{
    public GameObject cubeText;

    public void Start()
    {
        cubeText.SetActive(false);
    }

    public void OnMouseOver()
    {
        cubeText.SetActive(true);
    }

    public void OnMouseExit()
    {
        cubeText.SetActive(false);
    }
}
