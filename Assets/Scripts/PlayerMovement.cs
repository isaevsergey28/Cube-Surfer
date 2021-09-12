using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _xSpeed;
    [SerializeField] private float _zSpeed;
    [SerializeField] InputSystem _inputSystem;

    [SerializeField] GameObject _leftSide;
    [SerializeField] GameObject _rightSide;
    private void Update()
    {
        transform.Translate(_inputSystem.HorizontalInput * _xSpeed, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, _leftSide.transform.position.x, _rightSide.transform.position.x), transform.position.y, transform.position.z);
    }
}
