// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using System.Linq;
using UnityEngine;

// Note: See GenerateCube.cs for detailed comments (exact same process)

[RequireComponent(typeof(MeshFilter))]
public class GeneratePyramid : MonoBehaviour
{
    private void Start()
    {
        GetComponent<MeshFilter>().mesh = CreateMesh();
    }

    private Mesh CreateMesh()
    {
        var mesh = new Mesh
        {
            name = "Pyramid"
        };

        mesh.SetVertices(new[]
        {
            new Vector3(-1.0f, -1.0f, -1.0f), // Base
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),

            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),

            new Vector3(-1.0f, -1.0f, 1.0f), // Front
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(0.0f, 1.0f, 0.0f),

            new Vector3(1.0f, -1.0f, -1.0f), // Back
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(0.0f, 1.0f, 0.0f),

            new Vector3(-1.0f, -1.0f, -1.0f), // Left
            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(0.0f, 1.0f, 0.0f),

            new Vector3(1.0f, -1.0f, 1.0f), // Right
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(0.0f, 1.0f, 0.0f)
        });

        mesh.SetColors(new[]
        {
            Color.red, // Base
            Color.red,
            Color.red,

            Color.red,
            Color.red,
            Color.red,

            Color.yellow, // Front
            Color.yellow,
            Color.yellow,

            Color.green, // Back
            Color.green,
            Color.green,

            Color.blue, // Left
            Color.blue,
            Color.blue,

            Color.grey, // Right
            Color.grey,
            Color.grey
        });

        var indices = Enumerable.Range(0, mesh.vertices.Length).ToArray();
        mesh.SetIndices(indices, MeshTopology.Triangles, 0);

        return mesh;
    }
}