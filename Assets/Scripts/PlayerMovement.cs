using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _xSpeed;
    [SerializeField] private float _zSpeed;

    private InputSystem _inputSystem;

    private void Start()
    {
        _inputSystem = GetComponent<InputSystem>();
    }

    private void Update()
    {
        transform.Translate(_inputSystem.HorizontalInput * _xSpeed, 0, _zSpeed * Time.deltaTime);
    }
}
