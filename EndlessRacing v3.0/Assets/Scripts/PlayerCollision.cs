using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public CarController movement;
    public RoadSpawner roadSpawner;
    public GameObject gameOverPanel;
    public Text score;
    //AudioClip crash;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            roadSpawner.enabled = false;
            score.enabled = false;
            gameOverPanel.SetActive(true);
            FindObjectOfType<UIManager>().EndGame();
            //crash.Play();
        }
    }

}