using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VoxelData
{
    public static readonly Vector3[] voxel_vertex = new Vector3[8]{
        new Vector3(0.0f,0.0f,0.0f),
        new Vector3(1.0f,0.0f,0.0f),
        new Vector3(1.0f,1.0f,0.0f),
        new Vector3(0.0f,1.0f,0.0f),
        new Vector3(0.0f,0.0f,1.0f),
        new Vector3(1.0f,0.0f,1.0f),
        new Vector3(1.0f,1.0f,1.0f),
        new Vector3(0.0f,1.0f,1.0f)
    };

    public static readonly Vector3[] faceChecks = new Vector3[6]
    {
        new Vector3(0.0f,0.0f,-1.0f),
        new Vector3(0.0f,0.0f,1.0f),
        new Vector3(0.0f,1.0f,0.0f),
        new Vector3(0.0f,-1.0f,0.0f),
        new Vector3(-1.0f,0.0f,0.0f),
        new Vector3(1.0f,0.0f,0.0f),
    };

    public static readonly int[,] voxelTris = new int[6, 6]    {
        {0,3,1,1,3,2}, // BackFace
        {5,6,4,4,6,7}, // fronface
        {3,7,2,2,7,6}, // topface
        {1,5,0,0,5,4}, // Bottomface
        {4,7,0,0,7,3}, // leftface
        {1,2,5,5,2,6}  // Rightface
    };

    public static readonly Vector2[] voxelUVs = new Vector2[6]{
        new Vector2(0.0f,0.0f),
        new Vector2(0.0f,1.0f),
        new Vector2(1.0f,0.0f),
        new Vector2(1.0f,0.0f),
        new Vector2(0.0f,1.0f),
        new Vector2(1.0f,1.0f),

    };
}
