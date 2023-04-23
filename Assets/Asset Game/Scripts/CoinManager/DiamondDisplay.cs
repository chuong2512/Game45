using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiamondDisplay : MonoBehaviour
{
    public TextMeshProUGUI diamondTmp;

    void OnDestroy()
    {
        DirGameDataManager.Ins.playerData.onChangeDiamond -= i => OnChangeHelp(i);
    }

    void OnValidated()
    {
        diamondTmp = GetComponent<TextMeshProUGUI>();
    }

    private void OnChangeHelp(int i)
    {
        diamondTmp.text = $"{i}";
    }

    void Start()
    {
        DirGameDataManager.Ins.playerData.onChangeDiamond += i => OnChangeHelp(i);
        diamondTmp.text = $"{DirGameDataManager.Ins.playerData.intHelp}";
    }
}