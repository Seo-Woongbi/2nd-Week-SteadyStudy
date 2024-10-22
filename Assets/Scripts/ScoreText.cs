using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreButton.OnScoreChanged?.Invoke(1);
        scoreButton.OnScoreChanged += RefreshUI;
    }

    private void RefreshUI(int score)
    {
        scoreText.text = score.ToString();
    }
}
