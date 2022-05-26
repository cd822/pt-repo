using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleText : MonoBehaviour
{
    public GameObject capsuleText;

    public void Start()
    {
        capsuleText.SetActive(false);
    }

    public void OnMouseOver()
    {
        capsuleText.SetActive(true);
    }

    public void OnMouseExit()
    {
        capsuleText.SetActive(false);
    }
}
