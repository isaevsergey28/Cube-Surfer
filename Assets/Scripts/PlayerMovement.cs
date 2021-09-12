using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _xSpeed;
    [SerializeField] InputSystem _inputSystem;

    private void Update()
    {
        transform.Translate(_inputSystem.HorizontalInput * _xSpeed, 0, 0);
    }
}
