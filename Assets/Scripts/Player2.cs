using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private Vector2 player2Direction;
    public float player2Speed = 10.0f;
    protected Rigidbody2D player2Rigidbody;
    private void Awake()
    {
        player2Rigidbody =  GetComponent<Rigidbody2D>();
    }

    

    private void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            player2Direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            player2Direction = Vector2.down;
        } else { player2Direction = Vector2.zero;}

    }

    private void FixedUpdate()
    {
        if(player2Direction.sqrMagnitude != 0)
        {
            player2Rigidbody.AddForce(player2Direction * player2Speed);
        }
    }
    public void ResetAfterPointPlayer2()
    {
        player2Rigidbody.position = new Vector2(player2Rigidbody.position.x, 0.0f);
        player2Rigidbody.velocity = Vector2.zero;
    }
}
