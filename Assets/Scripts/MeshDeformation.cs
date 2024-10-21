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

        // Loop over each vertex in the mesh to modify its position
        for (int i = 0; i < _vertices.Length; i++)
        {
            // Store the original position of the current vertex
            Vector3 originalPos = _vertices[i];

            // Calculate the wave effect using a sine function
            float wave = amplitude * 0.05f * Mathf.Sin((Time.time * speed) - (originalPos.x * 5f));  // Smoother but gentler wave

            // Adjust the Y position for the vertex based on the calculated wave effect
            _vertices[i] = new Vector3(originalPos.x, originalPos.y + wave, originalPos.z);
        }

        // do not add code below 
        _mesh.vertices = _vertices;
        _mesh.RecalculateNormals();
    }

    private void Update()
    {
        if (!meshFilter) return;

        Animate();
    }
}
