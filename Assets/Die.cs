using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (GameManager.Instance.currentState != State.Lose)
        {
            GameManager.Instance.ShowLose();
        }
    }
}
