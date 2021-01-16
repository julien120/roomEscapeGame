using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource BGM;
    [SerializeField] AudioSource SE;

    [SerializeField] AudioClip[] bgmList;
    public enum BGMS
    {
        Title,
        Main,
        Clear
    };

    [SerializeField] AudioClip[] seList;
    public enum SES
    {
        Button,
        GimmickClear,
        GetItem
    };

    //シングルトン
    public static AudioManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }



    public void PlayBGM(BGMS bgms)
    {
        int index = (int)bgms;
        BGM.clip = bgmList[index]; //音をセット
        BGM.Play();


    }

    public void PlaySE(SES ses)
    {
        int index = (int)ses;
        AudioClip clip = seList[index];
        SE.PlayOneShot(clip);

    }




}
