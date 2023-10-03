using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static TextMeshProUGUI scoreText;

    static int scoreUp = 0;

    public static void ScoreUpdater()
    {
        scoreUp++;

        Debug.Log(scoreUp.ToString());

        scoreText.text = "Score: " + scoreUp.ToString();
    }
}
