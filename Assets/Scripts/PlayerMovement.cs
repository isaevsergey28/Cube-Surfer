using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _xSpeed;
    IInputSystem _inputSystem;

    private void Start()
    {
        _inputSystem = GetComponent<IInputSystem>();
    }
    public void StopPlayer()
    {
        Destroy(transform.parent.GetComponent<SplineFollower>());
        Destroy(this);
    }

    public void LaunchPlayer()
    {
       transform.parent.GetComponent<SplineFollower>().enabled = true;
    }

    private void Update()
    {
        transform.Translate(_inputSystem.InputValue * _xSpeed, 0, 0);
        RestrictMovement();
    }

    private void RestrictMovement()
    {
        Vector3 tempPos = transform.localPosition;
        tempPos.x = Mathf.Clamp(tempPos.x, -2f, 2f);
        transform.localPosition = tempPos;
    }

    
}
