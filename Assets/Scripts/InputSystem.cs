using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public float HorizontalInput { get; private set; }

    private void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime;
    }
}
