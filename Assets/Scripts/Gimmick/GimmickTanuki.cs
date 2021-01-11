using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickTanuki : MonoBehaviour
{
    //クリックされた時にleafを持っていれば消える
    public bool moved = false;



    public void PickTanuki()
    {
        bool hasLeaf = ItemBox.instance.CanUseItem(ItemManager.Item.Leaf); 
        if(hasLeaf == true)
        {
            MovedTanuki();
            ConversationManager.instance.ShowMessage("たぬきは葉っぱで消えた");
            ItemBox.instance.UseItem(ItemManager.Item.Leaf);
        }
        else
        {
            ConversationManager.instance.ShowMessage("葉っぱを持ってない");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        bool clearGimmick = SaveManager.instance.GetGimmick(SaveManager.Gimmick.MovedTanuki);
        if (clearGimmick == true)
        {
            MovedTanuki();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MovedTanuki()
    {
       
        moved = true;
        SaveManager.instance.SetGimmick(SaveManager.Gimmick.MovedTanuki);
        gameObject.SetActive(false);
    }
}
