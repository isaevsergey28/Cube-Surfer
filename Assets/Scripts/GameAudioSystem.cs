using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAudioSystem : MonoBehaviour
{
    [SerializeField] AudioSource _gameAduio;
    [SerializeField] AudioSource _lossAudio;
    [SerializeField] AudioSource _victoryAudio;

    private void Start()
    {
        _gameAduio.Play();
    }
    public void PlayVictoryAudio()
    {
        _gameAduio.Stop();
        _victoryAudio.Play();
    }

    public void PlayLossAudio()
    {
        _gameAduio.Stop();
        _lossAudio.Play();
    }
}
