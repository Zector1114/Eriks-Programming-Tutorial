using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public sealed class Score : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI scoreText;

    int scoreUp = 0;

    public void ScoreUpdater()
    {
        scoreUp++;

        scoreText.text = "Score: " + scoreUp.ToString();
    }

    private static Score instance = null;

    private void Start()
    {
        instance = this;
    }

    public static Score Instance
    {
        get
        {
            return instance;
        }
    }
}
