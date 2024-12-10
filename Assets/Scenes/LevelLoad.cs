using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public LevelData currentLevelData;
    public GameObject target;
    public GameObject obstaclePrefab;

    void Start()
    {
        LoadLevel();
    }

    void LoadLevel()
    {
        target.transform.position = currentLevelData.targetPosition;

        foreach (Vector2 position in currentLevelData.obstaclePositions)
        {
            Instantiate(obstaclePrefab, position, Quaternion.identity);
        }

        // Load background, etc.
    }
}

