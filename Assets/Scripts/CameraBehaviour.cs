using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private CubesSystem _cubesSystem;
    private float _positionYOffset;

    private void Start()
    {
        _positionYOffset = transform.position.y - _target.transform.position.y;
        _cubesSystem = _target.GetComponent<CubesSystem>();

        _cubesSystem.onAddingCubeEvent += DecreaseZCoord;
        _cubesSystem.onRemovingCubeEvent += IncreaseZCoord;
    }

    private void OnDisable()
    {
        _cubesSystem.onAddingCubeEvent -= DecreaseZCoord;
        _cubesSystem.onRemovingCubeEvent -= IncreaseZCoord;
    }

    private void LateUpdate()
    {
        Vector3 newCameraPos = new Vector3(transform.position.x, _target.transform.position.y + _positionYOffset, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newCameraPos, Time.deltaTime);
    }

    public void IncreaseZCoord()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.2f);
    }
    public void DecreaseZCoord()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.2f);
    }

}
