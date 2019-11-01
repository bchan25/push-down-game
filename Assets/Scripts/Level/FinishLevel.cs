using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            GameManager._instance.LevelComplete();
        }
    }
}
