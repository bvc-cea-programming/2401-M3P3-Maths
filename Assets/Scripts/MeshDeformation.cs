using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshDeformation : MonoBehaviour
{
    public MeshFilter meshFilter;
    public float speed = 5f;
    public float amplitude = 0.5f;
    //https://www.youtube.com/watch?v=5aXMMXPACpo
    private Mesh _mesh;
    private Vector3[] _vertices;
    private Vector3[] _MainV;

    private void Start()
    {
        _mesh = meshFilter.mesh;
        _vertices = _mesh.vertices;
        _MainV=_mesh.vertices.Clone() as Vector3[];
    }

    private void Animate()
    {
        // Add your code here
        for (int i = 0; i < _vertices.Length; i++)
        {
            Vector3 vertex = _MainV[i];
            vertex.y += amplitude * Mathf.Sin(Time.time * speed + vertex.x);
            
            _vertices[i] = vertex;
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
    //notes for me
    //using each  vertex's x position and using to change y position with the help of sine function
    //higher amplitude means higher wave 
    //it shift in x position and creates rippling effect.
}
