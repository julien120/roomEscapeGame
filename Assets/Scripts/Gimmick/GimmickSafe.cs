using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickSafe : MonoBehaviour
{
    //クリックした時に、鍵を持っていればopen
    //持ってない時は持っていないログ

    [SerializeField] GameObject door;

    void Start()
    {
        bool clearGimmick = SaveManager.instance.GetGimmick(SaveManager.Gimmick.OpenSafe);
        if (clearGimmick == true)
        {
            OpenDoor();
        }
    }

    public void OpenSafe()
    {
        bool hasKey = ItemBox.instance.CanUseItem(ItemManager.Item.Key);
        if(hasKey == true)
        {
            AudioManager.instance.PlaySE(AudioManager.SES.GimmickClear);
            SaveManager.instance.SetGimmick(SaveManager.Gimmick.OpenSafe);
            OpenDoor();
            ItemBox.instance.UseItem(ItemManager.Item.Key);
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
