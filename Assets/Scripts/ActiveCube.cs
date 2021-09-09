﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCube : MonoBehaviour
{
    private CubesSystem _activeCubes;
    private bool _isTriggered = false;

    private void OnEnable()
    {
        _activeCubes = transform.parent.gameObject.GetComponent<CubesSystem>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(!_isTriggered)
        {
            if (other.TryGetComponent<CollectableCube>(out CollectableCube collectableCube))
            {
                Destroy(collectableCube);
                _activeCubes.AddActiveCube(other.gameObject);
                _isTriggered = true;
            }
            else if (other.TryGetComponent<DestructionCube>(out DestructionCube destructionCube))
            {
                Destroy(destructionCube);
                _activeCubes.DeleteActiveCube(gameObject);
                _isTriggered = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        _isTriggered = false;
    }
}
