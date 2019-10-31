using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> levels;

    private int levelIndex = 0;


    public GameObject spawnLevel;


    public void LoadLevel()
    {
        spawnLevel =  Instantiate(levels[levelIndex], levels[levelIndex].transform.position, levels[levelIndex].transform.rotation);
    }

    public void DestroyCurrentLevel()
    {
        Destroy(spawnLevel.gameObject);
    }
}
