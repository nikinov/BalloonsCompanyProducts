using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshRenderer))]
public class MaterialHandler : MonoBehaviour
{
    private MeshRenderer renderer;
    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    public Material GetMaterial(int index)
    {
        if (index >= renderer.materials.Length) return null;

        return renderer.materials[index];
    }

    public void SetMaterial(Material material, int index)
    {
        if (index >= renderer.materials.Length) return;

        renderer.materials[index] = material;
    }

    public int Length()
    {
        return renderer.materials.Length;
    }
}
