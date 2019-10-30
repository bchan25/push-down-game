using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script change the Gravity of the world
public class Gravity : MonoBehaviour
{
    [SerializeField]
    float gravity = 9.81f;

    void Start()
    {
        Physics2D.gravity = new Vector2(0f, gravity);
    }

}
