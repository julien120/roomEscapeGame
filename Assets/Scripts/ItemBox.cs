using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] GameObject[] boxes;

    public static ItemBox instance;

    private void Awake()
    {
        //共通の変数を設け、且つ複数インスタンス化しないためにやってる？
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        for(int i=0; i<boxes.Length; i++)
        {
            boxes[i].SetActive(false);
        }
    }


    /// <summary>
    /// 表示/非表示でアイテムの獲得/使用を実装
    /// </summary>
    /// <param name="item"></param>
    public void SetItem(ItemManager.Item item)
    {
        int index = (int)item;
        boxes[index].SetActive(true);
    }

    public bool CanUseItem(ItemManager.Item item)
    {
        int index = (int)item;
        if(boxes[index].activeSelf == true)
        {
            return true;
        }
        return false;
    }

    public void UseItem(ItemManager.Item item)
    {
        int index = (int)item;
        boxes[index].SetActive(false);
    }
}
