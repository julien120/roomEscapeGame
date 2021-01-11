using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickedLocker : MonoBehaviour
{
    //ダイアルをクリアしたらロッカーを開く

    [SerializeField] GameObject door;

    private void Start()
    {
        bool clearGimmick = SaveManager.instance.GetGimmick(SaveManager.Gimmick.OpenLocker);
        if (clearGimmick == true)
        {
            OpenLocker();
        }
        else
        {

        }
    }

    public void OpenLocker()
    {
        door.SetActive(true);
        //fix:setGimmickを登録するとそのままアイテムをとったことになる
        SaveManager.instance.SetGimmick(SaveManager.Gimmick.OpenLocker);

    }
}
