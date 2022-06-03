using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{

    private int initAmount = 5;
    private float plotSize = 60f;
    private float xPosLeft = -39;
    private float xPosRight = 39;
    private float lastZPos;

    public List<GameObject> plots;

    void Start()
    {
        for(int i=0; i < initAmount; i++)
        {
            SpawnPlot();
        }
    }

    public void SpawnPlot()
    {
        GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        GameObject plotRight = plots[Random.Range(0, plots.Count)];

        float zPos = lastZPos + plotSize;

        GameObject plLeft = Instantiate(plotLeft, new Vector3(xPosLeft, 0.025f, zPos), plotLeft.transform.rotation) as GameObject;
        GameObject plRight = Instantiate(plotRight, new Vector3(xPosRight, 0.025f, zPos), new Quaternion(0, 180, 0, 0)) as GameObject;

        Destroy(plLeft, 8f);
        Destroy(plRight, 8f);

        lastZPos += plotSize;
    }
}
