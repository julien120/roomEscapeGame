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
    }

    public void OpenLocker()
    {
        door.SetActive(true);
        SaveManager.instance.SetGimmick(SaveManager.Gimmick.OpenLocker);
    }
}
