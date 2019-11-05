﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;


    void Update()
    {
        if (GameManager.Instance.startGame)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        

    }
}
