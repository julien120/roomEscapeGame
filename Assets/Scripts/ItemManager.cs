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
        Paper,
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
        ConversationManager.instance.ShowMessage(itemName(item)+"を手に入れた");
    }

    private string itemName(Item item)
    {
        switch (item)
        {
            case Item.Leaf:
                return "葉っぱ";
            case Item.Key:
                return "金庫の鍵";
            case Item.Card:
                return "エレベータキー";
            case Item.Hammer:
                return "ハンマー";
            case Item.Paper:
                return "焦げた紙";
        }
        return "";
    }

    private void SetItem()
    {
        gameObject.SetActive(false);
        ItemBox.instance.SetItem(item);
    }
}
