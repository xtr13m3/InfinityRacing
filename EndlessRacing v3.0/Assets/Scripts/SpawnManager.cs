using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    PlotSpawner plotSpawner;
    ObstaclesSpawner obstaclesSpawner;

    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        plotSpawner = GetComponent<PlotSpawner>();
        obstaclesSpawner = GetComponent<ObstaclesSpawner>();
    }

    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        plotSpawner.SpawnPlot();
        obstaclesSpawner.SpawnObstacles();
    }
}
