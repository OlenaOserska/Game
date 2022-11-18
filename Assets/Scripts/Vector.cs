using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    public Vector3 point1;
    public Vector3 point2;

    void Start()
    {
        Vector3 point3 = point1 + point2;

        GenerateCube(point1);
        GenerateCube(point2);
        GenerateCube(point3);

       /* GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = point1;
        GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = point2;

        GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube3.transform.position = point3;*/

    }
    private GameObject GenerateCube(Vector3 point)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = point;
        return cube;
    }

    void Update()
    {

    }
}
