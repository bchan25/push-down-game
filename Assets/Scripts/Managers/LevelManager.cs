using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> levelPrefabs;

    // The level to choose from array
    private int levelIndex = 0;
    [SerializeField]
    private int currentLevel = 1;

    [SerializeField]
    private int nextLevel = 2;
    

    private GameObject spawnLevel;


    // Progress Bar
    [SerializeField]
    private Transform finishLine;



    public void LoadLevel()
    {
        if(levelIndex >= levelPrefabs.Count)
        {
            Debug.Log("Complete whole game");
            // Random a level
            levelIndex = Random.Range(0, levelPrefabs.Count);
        }

        

        spawnLevel = Instantiate(levelPrefabs[levelIndex], levelPrefabs[levelIndex].transform.position, levelPrefabs[levelIndex].transform.rotation);
        finishLine = spawnLevel.transform.Find("Finish Line");
        
    }

    public void DestroyCurrentLevel()
    {
        Destroy(spawnLevel.gameObject);
    }

    public void LevelUp()
    {
        currentLevel++;
        levelIndex++;

        nextLevel++;
    }

    // Get the finish line;
    public Transform GetTheFinishLine()
    {
        return finishLine;
    }

    // Level Gui numbers
    public string GetCurrentLevel()
    {
        return currentLevel.ToString();
    }

    public string GetNextLevel()
    {
        return nextLevel.ToString();
    }

    // Score Manager
    public int GetCurrentLevelInt()
    {
        return currentLevel;
    }

}
