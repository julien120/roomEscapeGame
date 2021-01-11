using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickPig : MonoBehaviour
{
    [SerializeField] GameObject piggy;

    void Start()
    {
        bool clearGimmick = SaveManager.instance.GetGimmick(SaveManager.Gimmick.BrokenPig);
        if (clearGimmick == true)
        {
            BrokePiggy();
        }
    }

    public void DestroyPiggy()
    {
        bool hashammer = ItemBox.instance.CanUseItem(ItemManager.Item.Hammer);
        if (hashammer == true)
        {
            SaveManager.instance.SetGimmick(SaveManager.Gimmick.BrokenPig);
            BrokePiggy();
            ItemBox.instance.UseItem(ItemManager.Item.Hammer);
        }
        else
        {
            ConversationManager.instance.ShowMessage("壊せそうだ");
        }
    }

    private void BrokePiggy()
    {
        piggy.SetActive(true);
    }
}
