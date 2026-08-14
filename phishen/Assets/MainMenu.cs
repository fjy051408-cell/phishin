using UnityEngine;
using UnityEngine.SceneManagement; // 必须引入场景管理命名空间

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// 加载指定名称的场景。
    /// 在按钮的 OnClick 事件中选择此方法后，会提供一个输入框让你填写场景名字。
    /// </summary>
    /// <param name="sceneName">目标场景的名字（如 "Level1"）</param>
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// 退出游戏。
    /// 无需参数，直接绑定到退出按钮即可。
    /// </summary>
    public void QuitGame()
    {
        // 核心退出代码（打包为 exe 或 apk 后生效）
        Application.Quit();

        // 在 Unity 编辑器控制台输出提示，方便测试时知道按钮生效了
        Debug.Log("游戏退出代码已执行");
    }
}