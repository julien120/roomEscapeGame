using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public enum Item
    {
        Leaf,
        Key,
        Card,
        Hammer,
        paper,
        Max,
    }

    public Item item;


    private void Start()
    {
     
        bool hasItem = SaveManager.instance.GetItemData(item);
        bool usedItem = SaveManager.instance.GetUseData(item);
        if(usedItem == true)
        {
            gameObject.SetActive(false);
        }else if (hasItem == true)
        {
            SetItem();
        }
       
    }

    //クリックされた時にオブジェクトを消して、Item Boxに追加する

    public void ClickedItem()
    {
        SetItem();
    }

    private void SetItem()
    {
        gameObject.SetActive(false);
        ItemBox.instance.SetItem(item);
    }
}
