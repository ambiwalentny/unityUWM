using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    public AudioSource pongSound; 
    public float ballSpeed = 200.0f;
    private Rigidbody2D ballRigidbody;
    private void Awake()
    {
        ballRigidbody =  GetComponent<Rigidbody2D>();
        pongSound = GetComponent<AudioSource>();
    }
    private void Start()
    {
        ResetAfterPointBall();
        AddStartingForce();
    }
    public void AddStartingForce()
    {
        float x = Random.value;
        if(x < 0.5f)
        {
            x = -1.0f;
        }
        else 
        {
            x = 1.0f;
        }
        float y = Random.value;
        if(y < 0.5f)
        {
            y = Random.Range(-1f, -0.5f);
        }
        else
        {
            y = Random.Range(0.5f,  1f);
        }
        
        Vector2 direction = new Vector2(x,y);
        ballRigidbody.AddForce(direction*ballSpeed);
    }
    public void AddForce(Vector2 force)
    {
        ballRigidbody.AddForce(force);
    }

    public void ResetAfterPointBall()
    {
        ballRigidbody.position = Vector3.zero;
        ballRigidbody.velocity = Vector3.zero;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        pongSound.Play();
    }
}
