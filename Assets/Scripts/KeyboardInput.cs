using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour, IInputSystem
{
    public float InputValue
    {
        get { return _horizontalInput; }
        set { if (value >= 0) _horizontalInput = value; }
    }

    private float _horizontalInput;

    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime;
    }
}
