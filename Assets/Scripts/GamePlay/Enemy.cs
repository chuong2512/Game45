using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1;

    public Rigidbody2D rigidbody2D;

    void Update()
    {
        if (GameManager.Instance.currentState == State.Playing)
        {
            rigidbody2D.velocity = Vector2.down * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (GameManager.Instance.currentState != State.Lose)
        {
            GameManager.Instance.ShowLose();
        }
    }
}