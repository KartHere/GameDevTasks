using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 20f;
    private Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = velocity;
    }

    public void SetVelocity(Vector2 vel)
    {
        velocity = vel*speed;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Walls")
        {
            Destroy(gameObject);
        }
    }
}
