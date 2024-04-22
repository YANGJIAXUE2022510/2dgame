using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public Button button; // 引用按钮对象
    public TMP_Text timeText; // 引用 TextMeshPro 对象

    void Start()
    {
        //获取通用变量 周 凤临x年 正月
        string chineseYearString = GlobalVariables.GetChineseYearString(GlobalVariables.year);
        string chineseMonthString = GlobalVariables.GetChineseMonthString(GlobalVariables.month);
     timeText.text = GlobalVariables.dynasty+" "+GlobalVariables.era+GlobalVariables.GetChineseYearString(GlobalVariables.year)+" "+GlobalVariables.GetChineseMonthString(GlobalVariables.month);
       
         


        button = GetComponent<Button>();

        // 添加按钮点击事件监听器
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // 修改 TextMeshPro 的内容
        if(timeText != null)
        {
          GlobalVariables.IncrementMonth();
            timeText.text = GlobalVariables.dynasty+" "+GlobalVariables.era+GlobalVariables.GetChineseYearString(GlobalVariables.year)+" "+GlobalVariables.GetChineseMonthString(GlobalVariables.month);
        }
        else
        {
            Debug.LogWarning("TextMeshPro 对象未分配，请在Inspector面板中分配。");
        }
    }
}
