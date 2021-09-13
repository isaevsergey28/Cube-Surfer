using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAudioSystem : MonoBehaviour
{
    [SerializeField] private AudioClip _liftingBlockSound;
    [SerializeField] private AudioClip _deletionBlockSound;

    private CubesSystem _cubesSystem;

    private void Start()
    {
        _cubesSystem = transform.parent.GetComponent<CubesSystem>();
        _cubesSystem.onAddingCubeEvent += PlayLiftingBlockSound;
        _cubesSystem.onRemovingCubeEvent += PlayDeletionBlockSound;
    }

    private void OnDisable()
    {
        _cubesSystem.onAddingCubeEvent -= PlayLiftingBlockSound;
        _cubesSystem.onRemovingCubeEvent -= PlayDeletionBlockSound;
    }

    public void PlayLiftingBlockSound()
    {
        AudioSource.PlayClipAtPoint(_liftingBlockSound, transform.position);
    }

    public void PlayDeletionBlockSound()
    {
        AudioSource.PlayClipAtPoint(_deletionBlockSound, transform.position);
    }
}
