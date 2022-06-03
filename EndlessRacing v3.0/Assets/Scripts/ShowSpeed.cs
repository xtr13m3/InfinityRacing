using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowSpeed : MonoBehaviour
{

    public TMP_Text speed;
    public float velocity;

    void Update()
    {
            velocity = GameObject.FindWithTag("Player").GetComponent<CarController>().driveSpeed;
  
        speed.text = velocity.ToString("0");

    }
}
