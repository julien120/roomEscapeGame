using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelChanger : MonoBehaviour
{
    //後ほど定数管理する

    //矢印
    [SerializeField] GameObject rightArrow;
    [SerializeField] GameObject leftArrow;
    [SerializeField] GameObject backArrow;

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

    private void Start()
    {
        Show(Panel.Panel0);
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

            case Panel.Panel6:
                Show(Panel.Panel7);
                break;

            case Panel.Panel7:
                Show(Panel.Panel8);
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

            case Panel.Panel7:
                Show(Panel.Panel6);
                break;

            case Panel.Panel8:
                Show(Panel.Panel7);
                break;

        }
    }

    public void BackButton()
    {
        switch (currentPanel)
        {
            case Panel.Panel3:
                Show(Panel.Panel1);
                break;

            case Panel.Panel4:
                Show(Panel.Panel1);
                break;

            case Panel.Panel5:
                Show(Panel.Panel2);
                break;
        }
    }

    private void HideArrows()
    {
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        backArrow.SetActive(false);
    }

    //パネル内のアイテムに触るとパネル移動
    public void PickLocker()
    {
        Show(Panel.Panel3);
    }

    public void PickPig()
    {
        Show(Panel.Panel4);
    }

    public void PickBucket()
    {
        Show(Panel.Panel5);
    }

    public void GoHole()
    {
        Show(Panel.Panel6);
    }

    public void BackHole()
    {
        Show(Panel.Panel2);
    }

    /// <summary>
    /// アニメーションでシーンを切り替えてるかのように見えるパネル切り替え
    /// </summary>
    /// <param name="panel"></param>
    private void Show(Panel panel)
    {
        HideArrows();
        currentPanel = panel;
        switch (panel)
        {
            case Panel.Panel0:
                rightArrow.SetActive(true);
                transform.localPosition = new Vector2(0, 0);
                break;

            case Panel.Panel1:
                rightArrow.SetActive(true);
                leftArrow.SetActive(true);
                transform.localPosition = new Vector2(-1000, 0);
                break;

            case Panel.Panel2:
                leftArrow.SetActive(true);
                transform.localPosition = new Vector2(-2000, 0);
                break;

            case Panel.Panel3:
                backArrow.SetActive(true);
                transform.localPosition = new Vector2(0, 1500);
                break;

            case Panel.Panel4:
                backArrow.SetActive(true);
                transform.localPosition = new Vector2(-1000, 1500);
                break;

            case Panel.Panel5:
                backArrow.SetActive(true);
                transform.localPosition = new Vector2(-2000, 1500);
                break;

            case Panel.Panel6:
                rightArrow.SetActive(true);
                transform.localPosition = new Vector2(0, 3000);
                break;

            case Panel.Panel7:
                rightArrow.SetActive(true);
                leftArrow.SetActive(true);
                transform.localPosition = new Vector2(-1000, 3000);
                break;

            case Panel.Panel8:
                leftArrow.SetActive(true);
                transform.localPosition = new Vector2(-2000, 3000);
                break;

        }
    }
}
