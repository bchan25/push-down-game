using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> levels;

    private int levelIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        LoadLevel(levelIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadLevel(int level)
    {
        Instantiate(levels[level], levels[level].transform.position, levels[level].transform.rotation);
    }
}
