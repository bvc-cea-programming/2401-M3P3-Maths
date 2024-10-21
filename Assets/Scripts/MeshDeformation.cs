using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshDeformation : MonoBehaviour
{
    public MeshFilter meshFilter;
    public float speed = 5f;
    public float amplitude = 0.5f;

    private Mesh _mesh;
    private Vector3[] _vertices;

    private void Start()
    {
        _mesh = meshFilter.mesh;
        _vertices = _mesh.vertices;
    }

    private void Animate()
    {
        // Add your code here

        for(int i = 0; i < _vertices.Length; i++)
        {
            float posY = amplitude * Mathf.Sin(Time.time * speed + _vertices[i].x);
            _vertices[i] = new Vector3(_vertices[i].x, posY, _vertices[i].z);
        }

        // do not add code below 
        _mesh.vertices = _vertices;
        _mesh.RecalculateNormals();
    }

    private void Update()
    {
        if(!meshFilter) return;
        
        Animate();
    }
}
