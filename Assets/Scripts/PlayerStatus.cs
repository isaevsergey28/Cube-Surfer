using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    public void StopPlayer()
    {
        Destroy(transform.parent.GetComponent<SplineFollower>());
        Destroy(_playerMovement);
    }
}
