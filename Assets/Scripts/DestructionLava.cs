using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionLava : MonoBehaviour, IDestruction
{
    public void DestroyComponent()
    {
        Destroy(this);
    }
    public float GetDestroyTime()
    {
        return 0.1f;
    }
}
