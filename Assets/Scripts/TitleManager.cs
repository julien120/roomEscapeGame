using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField] GameObject continuButton;
    /// <summary>
    /// セーブデータがなければ、続きからボタンを表示しない
    /// </summary>
    private void Start()
    {
        AudioManager.instance.PlayBGM(AudioManager.BGMS.Title);
        bool hasSaveData = SaveManager.instance.HasSaveData();
        if(hasSaveData == true)
        {
            continuButton.SetActive(true);
        }
        else
        {
            continuButton.SetActive(false);
        }
    }

    public void StartButton()
    {
        AudioManager.instance.PlaySE(AudioManager.SES.Button);
        SaveManager.instance.CreateNewData();
        ToMainScene();
    }


    public void LoadDataButton()
    {
        SaveManager.instance.Load();
        ToMainScene();
    }

    private void ToMainScene()
    {
        SceneController.Instance.LoadMainScene();
    }

    public void ToClearScene()
    {
        SceneController.Instance.LoadClearScene();
    }


    public void ToTitleScene()
    {
        SceneController.Instance.LoadTitleScene();
    }
}
