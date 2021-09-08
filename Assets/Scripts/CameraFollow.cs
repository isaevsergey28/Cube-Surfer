using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private Vector3 _positionOffset;

    private void Start()
    {
        _positionOffset = transform.position - _target.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _target.transform.position + _positionOffset, Time.deltaTime);
    }
}
