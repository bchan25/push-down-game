using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> levels;

    private int levelIndex = 0;
    [SerializeField]
    private int currentLevel = 0;

    

    public GameObject spawnLevel;


    // Progress Bar
    [SerializeField]
    private Transform finishLine;



    public void LoadLevel()
    {
        spawnLevel =  Instantiate(levels[levelIndex], levels[levelIndex].transform.position, levels[levelIndex].transform.rotation);
        finishLine = spawnLevel.transform.Find("Finish Line");
    }

    public void DestroyCurrentLevel()
    {
        Destroy(spawnLevel.gameObject);
    }

    public void LevelUp()
    {
        currentLevel++;
    }

    // Get the finish line;
    public Transform GetTheFinishLine()
    {
        return finishLine;
    }

}
