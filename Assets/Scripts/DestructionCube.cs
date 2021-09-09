﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionCube : MonoBehaviour, IDestruction
{
    public void DestroyComponent()
    {
        Destroy(this);
    }

    public float GetDestroyTime()
    {
        return 0.3f;
    }
}
