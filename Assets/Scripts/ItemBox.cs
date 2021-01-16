using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] GameObject[] boxes;
    //[SerializeField] SaveManager saveManager;

    public static ItemBox instance;

    private void Awake()
    {
        
        if(instance == null)
        {
            instance = this;
        }
        //saveManager.Awa();
        for (int i = 0; i < boxes.Length; i++)
        {
            boxes[i].SetActive(false);
        }
    }

    private void Start()
    {
        

        //デーブデータがあると表示する

    }


    /// <summary>
    /// 表示/非表示でアイテムの獲得/使用を実装
    /// </summary>
    /// <param name="item"></param>
    public void SetItem(ItemManager.Item item)
    {
        int index = (int)item;
        boxes[index].SetActive(true);
        SaveManager.instance.SetItemData(item);
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
        SaveManager.instance.SetUseData(item);
    }
}
