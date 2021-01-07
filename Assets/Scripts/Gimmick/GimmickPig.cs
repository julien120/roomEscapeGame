using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickPig : MonoBehaviour
{
    [SerializeField] GameObject piggy;

    public void DestroyPiggy()
    {
        bool hashammer = ItemBox.instance.CanUseItem(ItemManager.Item.Hammer);
        if (hashammer == true)
        {
            BrokePiggy();
            ItemBox.instance.UseItem(ItemManager.Item.Hammer);
        }
        else
        {
            Debug.Log("鍵がかかってる");
        }
    }

    private void BrokePiggy()
    {
        piggy.SetActive(true);
    }
}
