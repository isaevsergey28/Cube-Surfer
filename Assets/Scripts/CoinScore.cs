using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    [SerializeField] private Text _textScore;

    private int _score = 0;

    private void Start()
    {
        Coin.onCoinSelectedEvent += ChangeScore;
    }

    private void OnDisable()
    {
        Coin.onCoinSelectedEvent -= ChangeScore;
    }

    private void ChangeScore()
    {
        _score++;
        _textScore.text = "Scroe : " + _score.ToString();
    }
}
