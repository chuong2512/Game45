using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using TMPro;
using UnityEngine;

public class HighPointing : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUgui;

    // Start is called before the first frame update
    void Start()
    {
        textMeshProUgui.SetText($"High Point : {DirGameDataManager.Ins.playerData.point}");
    }
}