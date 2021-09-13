using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAudioSystem : MonoBehaviour
{
    [SerializeField] AudioSource _gameAudio;
    [SerializeField] AudioSource _lossAudio;
    [SerializeField] AudioSource _victoryAudio;

    private void Start()
    {
        _gameAudio.Play();
    }

    public void PlayVictoryAudio()
    {
        _gameAudio.Stop();
        _victoryAudio.Play();
    }

    public void PlayLossAudio()
    {
        _gameAudio.Stop();
        _lossAudio.Play();
    }
}
