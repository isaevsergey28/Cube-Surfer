﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboadInput : MonoBehaviour
{
    [SerializeField] private PhysicsMovement _movement;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        _movement.Move(new Vector3(horizontal, 0, vertical));
    }
}
