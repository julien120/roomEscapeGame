using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickEleveator : MonoBehaviour
{
    [SerializeField] GameObject leftDoor;
    [SerializeField] GameObject rightDoor;


    public void OpenElevator()
    {
        bool haskey = ItemBox.instance.CanUseItem(ItemManager.Item.Card);
        if(haskey == true)
        {
            OpenDoor();
            ItemBox.instance.UseItem(ItemManager.Item.Card);
        }
    }

    private void OpenDoor()
    {
        leftDoor.SetActive(false);
        rightDoor.SetActive(false);
    }
}
