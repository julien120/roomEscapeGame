using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private static SceneController instance;

    //instanceに一意のインスタンスを格納し、これのみ参照する構造
    public static SceneController Instance
    {

        get
        {
            if (instance == null)
            {

                GameObject single = new GameObject();
                //instanceに格納されてる値を管理する
                instance = single.AddComponent<SceneController>();
                //scene跨いでもインスタンスが残るのでnull処理に行かない
                DontDestroyOnLoad(instance);

            }
            return instance;

        }
    }

    public void LoadTitleScene()
    {
        SceneManager.LoadScene(SceneName.InTitleScene);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(SceneName.InMainScene);
    }

    public void LoadClearScene()
    {
        SceneManager.LoadScene(SceneName.InClearScene);
    }
}