using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickSafe : MonoBehaviour
{
    //クリックした時に、鍵を持っていればopen
    //持ってない時は持っていないログ

    [SerializeField] GameObject door;

    public void OpenSafe()
    {
        bool hasKey = ItemBox.instance.CanUseItem(ItemManager.Item.Key);
        if(hasKey == true)
        {
            OpenDoor();
        }
        else
        {
            Debug.Log("鍵がかかってる");
        }
    }

    private void OpenDoor()
    {
        door.SetActive(true);
    }
}
