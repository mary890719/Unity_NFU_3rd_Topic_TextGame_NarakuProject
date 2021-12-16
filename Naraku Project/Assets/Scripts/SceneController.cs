using UnityEngine;
using UnityEngine.SceneManagement;  // 引用 場景管理 API

public class SceneController : MonoBehaviour
{
    /// <summary>
    /// 載入遊戲場景
    /// </summary>
    public void LoadGameScene(string SceneName)
    {
        // 場景管理.載入場景(場景名稱) - 載入指定的場景
        SceneManager.LoadScene(SceneName);
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();     // 應用程式.離開() - 關閉遊戲
    }
}
