using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickEleveator : MonoBehaviour
{
    [SerializeField] GameObject leftDoor;
    [SerializeField] GameObject rightDoor;

    private Animation animation;
    private bool moved = false;

    private void Awake()
    {
        animation = GetComponent<Animation>();
    }

    /// <summary>
    /// 仮に既にギミックをクリアしている状態でロードしたらそれを反映
    /// </summary>
    void Start()
    {
        bool clearGimmick = SaveManager.instance.GetGimmick(SaveManager.Gimmick.OpenElevator);
        if (clearGimmick == true)
        {
            OpenedDoor();
        }
    }

    public void OpenElevator()
    {
        if(moved == true)
        {
            return;
        }
        bool haskey = ItemBox.instance.CanUseItem(ItemManager.Item.Card);
        if(haskey == true)
        {
            OpenDoor();
            SaveManager.instance.SetGimmick(SaveManager.Gimmick.OpenElevator);
            ItemBox.instance.UseItem(ItemManager.Item.Card);
        }
        else
        {
            ConversationManager.instance.ShowMessage("キーが必要だ");
        }
    }

    private void OpenDoor()
    {
        moved = true;
        animation.Play();
       
    }

    private void OpenedDoor()
    {
        moved = true;
        leftDoor.SetActive(false);
        rightDoor.SetActive(false);
    }

}
