using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarController : MonoBehaviour
{

    public float driveSpeed = 10f;
    public float turnSpeed = 2f;
    private float lastSpeedRed = 0f;
    private const float speedInc = 0.2f;
    public SpawnManager spawnManager;

    [SerializeField] private GameObject gameOverPanel;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        if (driveSpeed < 100 && Time.time - lastSpeedRed >= speedInc)
        {
            driveSpeed += 2;
            lastSpeedRed = Time.time;
            if(turnSpeed != 12)
            {
                turnSpeed++;
            }
        }
        transform.Translate(new Vector3(inputX * turnSpeed, 0, driveSpeed) * Time.deltaTime);

        audioSource.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
