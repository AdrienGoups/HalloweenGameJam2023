using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboards : MonoBehaviour
{

    [SerializeField]
    private GameObject Billboard;
    [SerializeField]
    private GameObject Camera;
    private Vector3 CameraPosition;

    // Update is called once per frame
    void Update()
    {
        CameraPosition = Camera.transform.position;
        Billboard.transform.LookAt(CameraPosition);
    }
}
