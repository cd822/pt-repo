using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectText : MonoBehaviour
{
    public GameObject rectangleText;

    public void Start()
    {
        rectangleText.SetActive(false);
    }

    public void OnMouseOver()
    {
        rectangleText.SetActive(true);
    }

    public void OnMouseExit()
    {
        rectangleText.SetActive(false);
    }
}
