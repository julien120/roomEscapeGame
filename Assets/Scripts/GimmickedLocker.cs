using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickedLocker : MonoBehaviour
{
    //ダイアルをクリアしたらロッカーを開く

    [SerializeField] GameObject door;
    public void OpenLocker()
    {
        door.SetActive(true);
    }
}
