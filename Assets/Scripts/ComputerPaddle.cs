using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : MonoBehaviour
{
    public Rigidbody2D ball;
    private Vector2 computerDirection;
    public float computerSpeed = 10.0f;
    protected Rigidbody2D computerRigidbody;
    private void Awake()
    {
        computerRigidbody = GetComponent<Rigidbody2D>();
        
    }



    private void FixedUpdate()
    {
        if(ball.velocity.x >0.0f)
        {
            if (ball.transform.position.y > computerRigidbody.transform.position.y)  //ball above us
            {
                computerRigidbody.AddForce(Vector2.up * computerSpeed);
            }
            else  //ball under us
            {
                computerRigidbody.AddForce(Vector2.down * computerSpeed);
            }
        }
        else
            {
                if(computerRigidbody.transform.position.y > 0.0f)
                {
                    computerRigidbody.AddForce(Vector2.down * computerSpeed);
                }
                if(this.transform.position.y < 0.0f)
                {
                    computerRigidbody.AddForce(Vector2.up * computerSpeed);
                }
                
            }
    }
    public void ResetAfterPointComputer()
    {
        computerRigidbody.position = new Vector2 (computerRigidbody.position.x, 0.0f);
        computerRigidbody.velocity = Vector2.zero;
    }
}
