using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rb;
    private int directionInt;
    [SerializeField] private float speed = 4;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        rb.velocity = new Vector2(speed * directionInt, rb.velocity.y);
    }

    public void Move(int InputAx)
    {

        directionInt = InputAx;

    }
}
