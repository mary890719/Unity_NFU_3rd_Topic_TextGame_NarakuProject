using UnityEngine;
using UnityEngine.SceneManagement;  // �ޥ� �����޲z API

public class SceneController : MonoBehaviour
{
    /// <summary>
    /// ���J�C������
    /// </summary>
    public void LoadGameScene(string SceneName)
    {
        // �����޲z.���J����(�����W��) - ���J���w������
        SceneManager.LoadScene(SceneName);
    }

    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();     // ���ε{��.���}() - �����C��
    }
}
