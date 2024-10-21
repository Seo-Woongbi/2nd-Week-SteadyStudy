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
        scoreButton.scoreButton.onClick.AddListener(RefreshUI);
    }

    private void RefreshUI()
    {
        scoreText.text = scoreButton.score.ToString();
    }
}
