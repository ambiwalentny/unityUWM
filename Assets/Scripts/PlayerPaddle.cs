using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    private Vector2 playerDirection;
    public float playerSpeed = 10.0f;
    protected Rigidbody2D playerRigidbody;
    private void Awake()
    {
        playerRigidbody =  GetComponent<Rigidbody2D>();
    }

    

    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            playerDirection = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playerDirection = Vector2.down;
        } else { playerDirection = Vector2.zero;}

    }

    private void FixedUpdate()
    {
        if(playerDirection.sqrMagnitude != 0)
        {
            playerRigidbody.AddForce(playerDirection * playerSpeed);
        }
    }
    public void ResetAfterPointPlayer()
    {
        playerRigidbody.position = new Vector2(playerRigidbody.position.x, 0.0f);
        playerRigidbody.velocity = Vector2.zero;
    }
}
