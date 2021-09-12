using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrail : MonoBehaviour
{
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
    }
}
