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
        if (Input.GetKey(KeyCode.Space))
        {
            _horizontalInput = Input.GetAxis("Mouse X") * Time.deltaTime;
        }
    }
}
