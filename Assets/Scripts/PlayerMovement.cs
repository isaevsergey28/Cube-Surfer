using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _xSpeed;
    [SerializeField] InputSystem _inputSystem;

    private void Update()
    {
        transform.Translate(_inputSystem.HorizontalInput * _xSpeed, 0, 0);
    }

    public void StopPlayer()
    {
        Destroy(transform.parent.GetComponent<SplineFollower>());
        Destroy(this);
    }
}
