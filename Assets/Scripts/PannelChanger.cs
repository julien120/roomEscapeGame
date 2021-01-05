using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelChanger : MonoBehaviour
{
    //後ほど定数管理する

    //現在のパネル
    private Panel currentPanel;

    //Mainシーン内に配置しているパネル
    private enum Panel
    {
        Panel0,
        Panel1,
        Panel2,
        Panel3,
        Panel4,
        Panel5,
        Panel6,
        Panel7,
        Panel8,
    }

    /// <summary>
    /// Buttonを押したら他パネルに移動
    /// </summary>
    public void RightButton()
    {
        switch (currentPanel)
        {
            case Panel.Panel0:
                Show(Panel.Panel1);
                break;

            case Panel.Panel1:
                Show(Panel.Panel2);
                break;

        }
    }

    public void LeftButton()
    {
        switch (currentPanel)
        {
            case Panel.Panel1:
                Show(Panel.Panel0);
                break;

            case Panel.Panel2:
                Show(Panel.Panel1);
                break;

        }
    }

    public void BackButton()
    {

    }

    /// <summary>
    /// アニメーションでシーンを切り替えてるかのように見えるパネル切り替え
    /// </summary>
    /// <param name="panel"></param>
    private void Show(Panel panel)
    {
        currentPanel = panel;
        switch (panel)
        {
            case Panel.Panel0:
                transform.localPosition = new Vector2(0, 0);
                break;

            case Panel.Panel1:
                transform.localPosition = new Vector2(-1000, 0);
                break;

            case Panel.Panel2:
                transform.localPosition = new Vector2(-2000, 0);
                break;

            case Panel.Panel3:
                transform.localPosition = new Vector2(0, 1500);
                break;

            case Panel.Panel4:
                transform.localPosition = new Vector2(-1000, 1500);
                break;

            case Panel.Panel5:
                transform.localPosition = new Vector2(-2000, 1500);
                break;

            case Panel.Panel6:
                transform.localPosition = new Vector2(0, 3000);
                break;

            case Panel.Panel7:
                transform.localPosition = new Vector2(-1000, 3000);
                break;

            case Panel.Panel8:
                transform.localPosition = new Vector2(-2000, 3000);
                break;

        }
    }
}
