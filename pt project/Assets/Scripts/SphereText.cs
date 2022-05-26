using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereText : MonoBehaviour
{
    public GameObject sphereText;

    public void Start()
    {
        sphereText.SetActive(false);
    }

    public void OnMouseOver()
    {
        sphereText.SetActive(true);
    }

    public void OnMouseExit()
    {
        sphereText.SetActive(false);
    }
}
