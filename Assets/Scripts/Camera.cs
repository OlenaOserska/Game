using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float sensetyCam = 5;
    Transform cameraTransform;
    Vector3 deltaPosCam;
    Vector3 target;

    private void Start()
    {
        cameraTransform = transform;
        deltaPosCam = cameraTransform.position - player.position;
        deltaPosCam.z = -10;
    }
    private void Update()
    {
        
        target = player.transform.position + deltaPosCam;
        target.y = -0.5f;
        cameraTransform.position = Vector3.MoveTowards(cameraTransform.position, target, Time.deltaTime * sensetyCam);
    }
}
