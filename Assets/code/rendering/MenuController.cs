using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject[] buttonsToToggle; // 存储需要收缩/展开的按钮
    public Animator buttonAnimator; // 引用按钮的Animator组件

    void Start()
    {
        // 隐藏所有需要收缩/展开的按钮
        foreach (GameObject button in buttonsToToggle)
        {
            button.SetActive(false);
        }
    }

    public void ToggleButtons()
    {
        // 循环遍历所有需要收缩/展开的按钮
        foreach (GameObject button in buttonsToToggle)
        {
            // 切换按钮的激活状态（显示/隐藏）
            button.SetActive(!button.activeSelf);
        }

        // 获取Animator组件的当前状态
        bool isExpanded = buttonAnimator.GetBool("isExpanded");

        // 设置Animator参数以切换按钮的状态
        buttonAnimator.SetBool("isExpanded", !isExpanded);
    }
}
