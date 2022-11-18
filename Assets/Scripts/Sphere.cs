using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    //public Color[] colors;
    public int a;
    public int b;
    //int indexColor = 0;
    MeshRenderer mrSphere;

    void Start()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(0, 2, 0);
        mrSphere = sphere.GetComponent<MeshRenderer>();
        int h = a + b;
        sphere.transform.position = new Vector3(0, h, 0);

      
    }

    private void FixedUpdate()
    {
       
    }


    void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {
            mrSphere.material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        }

    }


}
