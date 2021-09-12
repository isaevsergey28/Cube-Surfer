using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCube : MonoBehaviour, IDestruction
{
    public void DestroyComponent()
    {
        Destroy(this);
    }

    public float GetDestroyTime()
    {
        return Mathf.Infinity;
    }
    
}
