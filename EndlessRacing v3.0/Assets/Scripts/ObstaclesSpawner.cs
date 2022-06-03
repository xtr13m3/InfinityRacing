using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public List<GameObject> obstacles;

    [SerializeField] private int numberOfObstacles = 4;
    [SerializeField] private float offset = 60f;
    private float lastZPos;
    float[] spawnPos = { -4.8f, -1.6f, 1.65f, 5f };


    void Start()
    {
        for (int i = 0; i < numberOfObstacles; i++)
        {
            SpawnObstacles();
        }
    }

    public void SpawnObstacles()
    {
        GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];
        GameObject obstacleOpposite = obstacles[Random.Range(0, obstacles.Count)];

        float zPos = lastZPos + offset;

        GameObject obst1;


        if (Random.Range(1, 5) <= 1)
        {
            int obs1 = Random.Range(0, 4);
            obst1 = obs1 >= 2 ? Instantiate(obstacle, new Vector3(spawnPos[obs1], -0.25f, Random.Range(zPos - 5f, zPos + 5f)), obstacle.transform.rotation) : Instantiate(obstacle, new Vector3(spawnPos[obs1], -0.25f, Random.Range(zPos - 5f, zPos + 5f)), obstacle.transform.rotation * Quaternion.Euler(0f, 180f, 0f));
        }
        else
        {
            int obs1 = Random.Range(2, 4);
            int obs2 = Random.Range(0, 2);

            obst1 = Instantiate(obstacle, new Vector3(spawnPos[obs1], -0.25f, Random.Range(zPos - 5f, zPos + 5f)), obstacle.transform.rotation);
            GameObject obstOpp = Instantiate(obstacleOpposite, new Vector3(spawnPos[obs2], -0.25f, Random.Range(zPos - 5f, zPos + 5f)), obstacle.transform.rotation * Quaternion.Euler(0f, 180f, 0f));
            Destroy(obstOpp, 12f);
        }

        Destroy(obst1, 12f);
        lastZPos += offset;
    }
}