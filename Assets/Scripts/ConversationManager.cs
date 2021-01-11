using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour
{
    //会話UIの表示・非表示・テキストの変更を実装

    [SerializeField] GameObject textUI;
    [SerializeField] Text message;

    //この場合の共通化はstaticを用いるのが好ましいのかどうか？
    public static ConversationManager instance;

    private void Awake()
    {  
       instance = this;
    }

    private void ShowMessageUI()
    {
        textUI.SetActive(true);
    }

    public void HideMessageUI()
    {
        textUI.SetActive(false);
    }

    public void ShowMessage(string conversation)
    {
        message.text = conversation;
        ShowMessageUI();
    }

}
