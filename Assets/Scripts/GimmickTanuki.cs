using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickTanuki : MonoBehaviour
{
    //クリックされた時にleafを持っていれば消える

    public void PickTanuki()
    {
        bool hasLeaf = ItemBox.instance.CanUseItem(ItemManager.Item.Leaf); 
        if(hasLeaf == true)
        {
            gameObject.SetActive(false);
            ItemBox.instance.UseItem(ItemManager.Item.Leaf);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
