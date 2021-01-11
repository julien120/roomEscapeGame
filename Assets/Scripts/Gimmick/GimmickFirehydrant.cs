using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickFirehydrant : MonoBehaviour
{
    //指定した回数・順番でのクリックにより開場するギミックの実装

    [SerializeField] GameObject door;
    private enum Direction
    {
        Left = 0,
        Right = 1,
    }


    private Direction[] correctAnswer = {
        Direction.Right,
        Direction.Left,
        Direction.Left,
        Direction.Right,
        Direction.Right,
    };

    private List<Direction> userInputs = new List<Direction>();

    void Start()
    {
        bool clearGimmick = SaveManager.instance.GetGimmick(SaveManager.Gimmick.OpenedFireHy);
        if (clearGimmick == true)
        {
            door.SetActive(true);
        }
    }

    /// <summary>
    /// ユーザーの入力をuserInputsに代入し、正解の順番と照合する
    /// </summary>
    /// <param name="type"></param>
    public void ClickButton(int type)
    {
        if(type == 0)
        {
            userInputs.Add(Direction.Left);
        }else if(type == 1)
        {
            userInputs.Add(Direction.Right);
        }

        if(userInputs.Count == 5)
        {
            if(IsClear() == true)
            {
                Clear();
            }
            else
            {
                ResetInput();
            }
        }
    }

    private bool IsClear()
    {
        for(int i=0; i< userInputs.Count; i++)
        {
            if(userInputs[i] != correctAnswer[i])
            {
                return false;
            }
        }
        return true;
    }

    private void Clear()
    {
        SaveManager.instance.SetGimmick(SaveManager.Gimmick.OpenedFireHy);
        door.SetActive(true);
    }

    private void ResetInput()
    {
        ConversationManager.instance.ShowMessage("間違ってるようだ");
        userInputs.Clear();
    }
}
