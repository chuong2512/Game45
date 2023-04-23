using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawnnning : MonoBehaviour
{
    public float time, timeCount = 3;

    public GameObject[] spawnTree;

    void Update()
    {
        if (GameManager.Instance.currentState == State.Playing)
        {
            time -= Time.deltaTime;

            if (time <= 0)
            {
                SpawnObj();
                time = timeCount;
            }
        }
    }

    private void SpawnObj()
    {
        Instantiate(spawnTree[Random.Range(0, spawnTree.Length)], transform.position, transform.rotation);
    }
}