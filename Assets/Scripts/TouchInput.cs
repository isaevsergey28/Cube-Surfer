using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour, IInputSystem
{
    public float InputValue
    {
        get { return _horizontalInput; }
        set { if (value >= 0) _horizontalInput = value; }
    }
    private float _horizontalInput;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Vector3 touchDeltaPosition = (Vector3)Input.GetTouch(0).deltaPosition;
            _horizontalInput = touchDeltaPosition.x;
        }
    }
}
