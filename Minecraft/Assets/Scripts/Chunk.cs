using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public MeshRenderer Mesh_Renderer;
    public MeshFilter Mesh_filter;
    int vertexIndex = 0;
    List<Vector3> vertices = new List<Vector3>();
    List<int> triangles = new List<int>();
    List<Vector2> uvs = new List<Vector2>();

    

    private void Start()
    {

       // AddingvoxelDataToChunk(transform.position);
      //  CreateMesh();
    }

 public void AddingvoxelDataToChunk(Vector3 pos)
    {
        for (int p = 0; p < 6; p++)
        {
            for (int i = 0; i < 6; i++)
            {
                int triangleIndex = VoxelData.voxelTris[p, i];
                vertices.Add(VoxelData.voxel_vertex[triangleIndex] + pos);
                triangles.Add(vertexIndex);

                uvs.Add(VoxelData.voxelUVs[i]);
                vertexIndex++;
            }
        }
    }

  public  void CreateMesh()
    {
        Mesh mesh = new Mesh();
        mesh.vertices = vertices.ToArray();
        mesh.triangles = triangles.ToArray();
        mesh.uv = uvs.ToArray();

        mesh.RecalculateNormals();
        Mesh_filter.mesh = mesh;
    }
}
