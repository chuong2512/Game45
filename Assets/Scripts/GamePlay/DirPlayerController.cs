using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using Sirenix.OdinInspector;
using UnityEngine;

public class DirPlayerController : Singleton<DirPlayerController>
{
    public Rigidbody2D Rigidbody2D;
    private bool play;

    public Quaternion right, left;

    public void Play(bool right)
    {
    }

    public float speed = 2;
    public bool isRight = true;

    public void Play()
    {
        play = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.Instance.currentState != State.Lose)
        {
            ChangeDirFly();
        }
    }

    [Button]
    private void ChangeDirFly()
    {
        transform.rotation = isRight ? this.right : this.left;
        Rigidbody2D.velocity = isRight ? Vector2.right * speed : Vector2.left * speed;
        isRight = !isRight;
    }
}