using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Vector3 _startPos;


    void Start()
    {
        transform.position = _startPos;
    }

    
    void Update()
    {
        
    }

    // Actions

    void PushDown()
	{
        // When input tap push object down
	}

    void Die()
	{
        // When collide with obstacle kill player
	}

}
