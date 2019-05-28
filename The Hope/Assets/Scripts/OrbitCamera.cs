using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 _offset;

    private void Start()
    {
        _offset = target.position - transform.position;
    }

    private void LateUpdate()
    {
        transform.position = target.position - (_offset);

    }
}
