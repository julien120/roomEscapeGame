﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;

    public enum Gimmick
    {
        OpenLocker,
        MovedTanuki,
        MovedTea,
        OpenSafe,
        Max,
    }


    public void Awake()
    {
        Debug.Log("save");
        instance = this;
        Load();
        
    }


    private const string Save_Key = "SaveData";
    [SerializeField] SaveData saveData;

    /// <summary>
    /// セーブデータをjson化する
    /// </summary>

    private void Save()
    {
        string json = JsonUtility.ToJson(saveData);
        PlayerPrefs.SetString(Save_Key, json);
    }

    /// <summary>
    /// PlayerPrefsでjsonを取得し、jsonをクラス変換する
    /// </summary>
    private void Load()
    {
        saveData = new SaveData();
        if(PlayerPrefs.HasKey(Save_Key) == true)
        {
            string json = PlayerPrefs.GetString(Save_Key);
            saveData = JsonUtility.FromJson<SaveData>(json);
        }
    }

    public void SetItemData(ItemManager.Item item)
    {
        int index = (int)item;
        saveData.getItems[index] = true;
        Save();
    }

    public bool GetItemData(ItemManager.Item item)
    {
        int index = (int)item;
        return saveData.getItems[index];
    }

    public void SetUseData(ItemManager.Item item)
    {
        int index = (int)item;
        saveData.useItems[index] = true;
        Save();
    }

    public bool GetUseData(ItemManager.Item item)
    {
        int index = (int)item;
        return saveData.useItems[index];
    }


    public void SetGimmick(Gimmick gimmick)
    {
        int index = (int)gimmick;
        saveData.getItems[index] = true;
        Save();
    }

    public bool GetGimmick(Gimmick gimmick)
    {
        int index = (int)gimmick;
        return saveData.getItems[index];
    }

}



[Serializable] public class SaveData
{
    public bool[] getItems = new bool[(int)ItemManager.Item.Max]; //取得したアイテム
    public bool[] useItems = new bool[(int)ItemManager.Item.Max]; //使用したアイテム
    public bool[] gimmick = new bool[(int)SaveManager.Gimmick.Max];
}
