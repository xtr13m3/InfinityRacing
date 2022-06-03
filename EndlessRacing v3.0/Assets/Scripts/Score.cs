using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    public TMP_Text scoreGO;

    void Update()
    {
        score.text = player.position.z.ToString("0");

        if (player.position.z > PlayerPrefs.GetFloat("highScore"))
        {
            PlayerPrefs.SetFloat("highScore", player.position.z);
            scoreGO.text = player.position.z.ToString("0");
        }
        
    }
}
