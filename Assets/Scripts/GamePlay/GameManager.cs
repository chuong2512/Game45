using System;
using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public enum State
{
    Start,
    Playing,
    Lose,
}

public class GameManager : Singleton<GameManager>
{
    public State currentState = State.Start;

    public GameObject loseObj, tap;

    public TextMeshProUGUI point, highPoint;

    public GameObject[] respawns;

    public void SetState(State state)
    {
        currentState = state;
    }

    public void Restart(bool up)
    {
        if (up)
        {
            DirGameDataManager.Ins.playerData.LevelUP();
        }

        SceneManager.LoadScene("Game");
    }

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentState != State.Playing)
        {
            tap.SetActive(false);
            SetState(State.Playing);
            DirPlayerController.Instance.Play();
        }
    }

    private bool CheckWin()
    {
        return true;
    }

    public void MoveColor(TesterTube tube)
    {
    }

    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }
    

    public void ShowLose()
    {
        loseObj.SetActive(true);

        SetState(State.Lose);

        point.SetText($"Your Score : {TheLevelTMP.Instance.point}");

        DirGameDataManager.Ins.playerData.SetPoint(TheLevelTMP.Instance.point);

        highPoint.SetText($"High Score : {DirGameDataManager.Ins.playerData.point}");
    }

    public void ReStart()
    {
        SceneManager.LoadScene("Game");
    }

    
    
    public void Help()
    {
    }

    public void Continue()
    {
        if (DirGameDataManager.Ins.playerData.intHelp >= 10)
        {
            DirGameDataManager.Ins.playerData.SubHelp(10);
            loseObj.SetActive(false);

            respawns = GameObject.FindGameObjectsWithTag("Enemy");

            if (respawns != null)
            {
                foreach (GameObject respawn in respawns)
                {
                    Destroy(respawn);
                }
            }

            SetState(State.Playing);
        }
    }
}