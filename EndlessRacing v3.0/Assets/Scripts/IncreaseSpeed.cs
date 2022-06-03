using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{
    public Transform player;
    CarController carController;
    private void Start()
    {
        carController = GameObject.FindWithTag("Player").GetComponent<CarController>();
    }

    void Update()
    {
        if (player.position.z > 2000f && player.position.z < 6000)
        {
            carController.driveSpeed = 100f;
        }
        else if (player.position.z > 6000 && player.position.z < 12000)
        {
            carController.driveSpeed = 120f;
        }
        else if(player.position.z > 12000 && player.position.z < 25000)
        {
            carController.driveSpeed = 150f;
        }
    }
}
