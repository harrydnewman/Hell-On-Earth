using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PongBall : MonoBehaviour
{
    public float speed = 200f;
    public new Rigidbody2D rigidbody { get; private set; }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        rigidbody.position = Vector2.zero;
        rigidbody.velocity = Vector3.zero;

        
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) :
                                        Random.Range(0.5f, 1f);
        Vector2 direction = new Vector2(x, y);
        rigidbody.AddForce(direction * this.speed);
    }
    public void AddForce(Vector2 force)
    {
        rigidbody.AddForce(force);
    }


}
