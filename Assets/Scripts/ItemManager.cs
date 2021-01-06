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
    }

    public Item item;

    //クリックされた時にオブジェクトを消して、Item Boxに追加する

    public void ClickedItem()
    {
        gameObject.SetActive(false);
        ItemBox.instance.SetItem(item);
    }
}
