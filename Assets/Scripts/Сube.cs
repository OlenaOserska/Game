using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Сube : MonoBehaviour
{
    public GameObject prefab;
    private const int COUNT_TO_SPAWN = 5;
    void Start()
    {
        SpawnMorePrefab();
    }

    
    void SpawnPrefab()
    {
       GameObject generateObject = Instantiate(prefab);
        generateObject.transform.position = new Vector2(0, 1);
    }
    void SpawnMorePrefab()
    {
        for(int i = 0; i < COUNT_TO_SPAWN; i++)
        {
            GameObject generateObject = Instantiate(prefab);
            generateObject.transform.position = new Vector2(0, i);
        }
    }
}
