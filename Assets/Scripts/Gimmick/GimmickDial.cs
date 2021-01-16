using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GimmickDial : MonoBehaviour
{
    /// <summary>
    /// 3つのボタンをそれぞれクリックして絵柄を一致させるとドアが開くギミック
    /// </summary>

    [SerializeField] Image[] buttons;

    private enum Mark
    {
        Maru,
        Sankaku,
        Hoshi,
        Dia
    }

    private Mark[] currentMarks = { Mark.Maru, Mark.Maru, Mark.Maru };

    private Mark[] AnswerMarks = { Mark.Maru, Mark.Sankaku, Mark.Hoshi };

    [SerializeField] Sprite[] resourceSprites;

    [SerializeField] UnityEvent ClearEvent;
    
    public void ClickMark(int position)
    {
        ChangeMark(position);
        ShowMark(position);

        if(IsAllClear() == true)
        {
            ClearMark();
        }
    }

    private void ChangeMark(int position)
    {
        currentMarks[position]++; //ダイアルを替える
        if (currentMarks[position]> Mark.Dia)
        {
            currentMarks[position] = Mark.Maru;
        }
    }

    private void ShowMark(int position)
    {
        int index = (int)currentMarks[position];
        buttons[position].sprite = resourceSprites[index];
    }

    private bool IsAllClear()
    {
        for(int i=0; i<currentMarks.Length; i++)
        {
            if(currentMarks[i] != AnswerMarks[i])
            {
                //一つでも違ったらfalse
                return false;
            }
        }
        return true;
    }

    private void ClearMark()
    {
        AudioManager.instance.PlaySE(AudioManager.SES.GimmickClear);
        //ロッカーを開ける
        ConversationManager.instance.ShowMessage("ロッカーが開いた");
        ClearEvent.Invoke();
    }

}
