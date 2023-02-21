using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gradient : MonoBehaviour
{
    public Material material;

    private Slider color;
    public float hue;

    void Start()
    {
        color = this.gameObject.GetComponent<Slider>();
    }

    public void GetColor()
    {
        hue = color.value;
        material.SetFloat("_hue", hue);
    }
}
