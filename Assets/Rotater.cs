using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float speed = 1;

    public bool right = false;
    private float time;
    public float timeCount = 2;

    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles + Vector3.forward * speed);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles - Vector3.forward * speed);
        }

        time -= Time.deltaTime;

        if (time < 0)
        {
            right = !right;
            time = timeCount;
        }
    }
}