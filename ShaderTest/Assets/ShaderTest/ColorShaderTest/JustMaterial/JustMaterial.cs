using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustMaterial : MonoBehaviour
{
    Renderer OBJ;
    
    void Start()
    {
        OBJ = gameObject.GetComponent<Renderer>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            OBJ.material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            OBJ.material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            OBJ.material.color = Color.cyan;
        }
    }
}
