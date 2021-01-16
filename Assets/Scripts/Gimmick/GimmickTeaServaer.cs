using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickTeaServaer : MonoBehaviour
{
    public GimmickTanuki tanuki;
    private Animation animation;
    private bool moved = false;

    void Start()
    {
        animation = GetComponent<Animation>();
        bool clearGimmick = SaveManager.instance.GetGimmick(SaveManager.Gimmick.MovedTea);
        if (clearGimmick == true)
        {
            moved = true;
            MovedTeaServer();
        }
    }

    public void clickTeaServer()
    {
        if(moved == true)
        {
            return;
        }
        bool movedTanuki = tanuki.moved;
        if(movedTanuki == true)
        {
            AudioManager.instance.PlaySE(AudioManager.SES.GimmickClear);
            SaveManager.instance.SetGimmick(SaveManager.Gimmick.MovedTea);
            MovedTeaServer();
        }
        else
        {
            ConversationManager.instance.ShowMessage("たぬきがいて動かせない");
        }
    }

    private void MovedTeaServer()
    {
        moved = true;
        animation.Play();
        //gameObject.SetActive(false);
    }
}
