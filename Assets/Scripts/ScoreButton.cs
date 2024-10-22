using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public event Action <int> OnScoreChanged;
    public int score = 0;
    
    private void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    private void PointUp()
    {
        score += 1;
        OnScoreChanged?.Invoke(score);
    }
}
