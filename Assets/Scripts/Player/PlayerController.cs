using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    [SerializeField]
    private Vector3 _startPos;

    [SerializeField]
    private float downForce;
    private Rigidbody2D rb;

    private bool canTouch = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.position = _startPos;
    }

    
    void Update()
    {
        if (!GameManager.Instance.startGame)
            return;

        if (canTouch)
        {
            if (Input.GetMouseButtonDown(0))
            {
                PushDown();
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.Instance.GameOver();
            // Set Active
            gameObject.SetActive(false);
        }
    }

    // Actions

    void PushDown()
	{
        // When input tap push object down
        //...zero out the birds current y velocity before...
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0, -downForce));
    }


    public void SetOnTouch()
    {
        canTouch = true;
    }

    public void DisableTouch()
    {
        canTouch = false;
    }


    public void ResetPlayer()
    {
        gameObject.SetActive(true);
        transform.position = _startPos;
        transform.localRotation = Quaternion.identity;
    }

}
