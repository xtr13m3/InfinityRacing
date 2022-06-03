using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScores : MonoBehaviour
{
    public TMP_Text score;
    
    void Update()
    {
        float highscore = PlayerPrefs.GetFloat("highScore");
        score.text = highscore.ToString("0");
    }
}
