using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "Game/LevelData")]
public class LevelData : ScriptableObject
{
    public Vector2 targetPosition;
    public Vector2[] obstaclePositions;
    public string backgroundName;
}

