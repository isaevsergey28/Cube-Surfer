using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCube : MonoBehaviour
{
    public void DestroyComponent()
    {
        Destroy(this);
    }

    public float GetDestroyTime()
    {
        return float.NaN;
    }
    
}
