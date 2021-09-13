using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubesSystem : MonoBehaviour
{
    [SerializeField] private List<GameObject> _activeCubes = new List<GameObject>();
    [SerializeField] private UnityEvent _onRemovingLastCubeEvent;
    [SerializeField] private VictoryEvent _onWinEvent;

    public delegate void OnChangedCubesCount();
    public event OnChangedCubesCount onAddingCubeEvent;
    public event OnChangedCubesCount onRemovingCubeEvent;

    private int _finalScore = 0;

    private void Start()
    {
        foreach(Transform child in transform)
        {
            if(child.gameObject.TryGetComponent<ActiveCube>(out ActiveCube cube))
            {
                _activeCubes.Add(child.gameObject);
            }
        }
    }

    public void AddActiveCube(GameObject newCube)
    {
        onAddingCubeEvent?.Invoke();
        newCube.transform.position = _activeCubes[_activeCubes.Count - 1].transform.position;
        transform.position = transform.position + new Vector3(0, 1, 0);
        newCube.transform.parent = transform;
        _activeCubes.Add(newCube);
        newCube.AddComponent<ActiveCube>();
        
    }

    public void DeleteActiveCube(GameObject removableCube, float destroyTime)
    {
        DestroyCube(removableCube);
        StartCoroutine(ReduceHeight(destroyTime));
        if(_activeCubes.Count == 0)
        {
            _onRemovingLastCubeEvent?.Invoke();
        }
    }

    public void DeleteCubeOnFinishPlatforms(GameObject removableCube)
    {
        DestroyCube(removableCube);
        if (_activeCubes.Count == 0)
        {
            InvokeAboutVictory();
            return;
        }

        _finalScore += 5;
    }

    public void InvokeAboutVictory()
    {
        _onWinEvent?.Invoke(_finalScore);
    }

    private void DestroyCube(GameObject removableCube)
    {
        onRemovingCubeEvent?.Invoke();
        _activeCubes.Remove(removableCube);
        Destroy(removableCube);
    }

    private IEnumerator ReduceHeight(float destroyTime)
    {
        yield return new WaitForSeconds(destroyTime);
        transform.position = transform.position - new Vector3(0, 1, 0);
    }
}

[System.Serializable]
public class VictoryEvent : UnityEvent<int> { }