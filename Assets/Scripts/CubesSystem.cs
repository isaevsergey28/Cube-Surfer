using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesSystem : MonoBehaviour
{
    [SerializeField] private List<GameObject> _activeCubes = new List<GameObject>();

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
        newCube.transform.position = _activeCubes[_activeCubes.Count - 1].transform.position;
        transform.position = transform.position + new Vector3(0, 1, 0);
        newCube.transform.parent = transform;
        _activeCubes.Add(newCube);
        newCube.AddComponent<ActiveCube>();
    }
    public void DeleteActiveCube(GameObject removableCube, float destroyTime)
    {
        _activeCubes.Remove(removableCube);
        Destroy(removableCube);
        StartCoroutine(ReduceHeight(destroyTime));
    }
    private IEnumerator ReduceHeight(float destroyTime)
    {
        yield return new WaitForSeconds(destroyTime);
        transform.position = transform.position - new Vector3(0, 1, 0);
    }
}
