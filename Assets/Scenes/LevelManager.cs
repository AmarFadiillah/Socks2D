using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] levels; // Array berisi prefab level
    private int currentLevel;

    void Start()
    {
        LoadLevel(currentLevel);
    }

    public void LoadLevel(int levelIndex)
    {
        foreach (GameObject level in levels)
            level.SetActive(false); // Nonaktifkan semua level

        levels[levelIndex].SetActive(true); // Aktifkan level yang diinginkan
    }

    public void NextLevel()
    {
        if (currentLevel < levels.Length - 1)
        {
            currentLevel++;
            LoadLevel(currentLevel);
        }
    }
}

