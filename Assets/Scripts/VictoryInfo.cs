using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryInfo : MonoBehaviour
{
    [SerializeField] private Text _finalScoreText;

    public void SetFinalScore(int score)
    {
        _finalScoreText.text += score.ToString();
    }
}
