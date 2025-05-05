using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float sensivity = 100;

    private Transform playerBody;
    private float xRotation = 0;

    void Start()
    {
        playerBody = transform.parent;
    }

    void Update()
    {
        
    }
}
