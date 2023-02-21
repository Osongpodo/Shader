using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    private Material material;
    private Color previousColor;
    
    private void Start()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
        previousColor = material.GetColor("_BaseColor");
        material.SetColor("_RippleColor", previousColor);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastClickRay();
        }
    }

    private void CastClickRay()
    {
        var camera = Camera.main;
        var mousePosition = Input.mousePosition;
        var ray = camera.ScreenPointToRay(new Vector3(mousePosition.x, mousePosition.y, camera.nearClipPlane));
        if(Physics.Raycast(ray, out var hit) && hit.collider.gameObject == gameObject)
        {
            StartRipple(hit.point);
        }
    }

    private void StartRipple(Vector3 center)
    {
        Color rippleColor = Color.HSVToRGB(Random.value, 1, 1);

        material.SetVector("_RippleCenter", center);
        material.SetFloat("_RippleStartTime", Time.time);
        material.SetColor("_BaseColor", previousColor);
        material.SetColor("_RippleColor", rippleColor);

        previousColor = rippleColor;
    }
}
