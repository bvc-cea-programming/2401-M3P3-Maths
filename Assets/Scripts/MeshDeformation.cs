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
        meshFilter = GetComponent<MeshFilter>();
        _vertices = meshFilter.mesh.vertices;
    }



    private void Animate()
    {
        // Add your code here

        Mesh mesh = meshFilter.mesh; // Get the current mesh
        Vector3[] vertices = _vertices; // Start with the original vertices array

        // Modify the y value of each vertex to create a wave effect
        for (int i = 0; i < vertices.Length; i++)
        {
            // Calculate new Y position based on sine wave formula
            vertices[i].y = amplitude * Mathf.Sin(Time.time * speed + vertices[i].x);
        }

        // Assign the modified vertices back to the mesh
        mesh.vertices = vertices;

        // Recalculate normals for proper lighting
        mesh.RecalculateNormals();

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
