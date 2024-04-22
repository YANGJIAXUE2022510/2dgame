using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnterCity : MonoBehaviour
{
    public TMP_Text cityText; // 引用 TextMeshPro 对象
    public Button button; // 引用按钮对象
    // Start is called before the first frame update
    void Start()
    {

        button = GetComponent<Button>();

        // 添加按钮点击事件监听器
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (cityText != null)
        {
            // 获取格式化后的地图信息
            string formattedMap = GlobalVariables.GetFormattedMap(1);

            // 将格式化后的字符串赋值给 cityText 的 text 属性
            cityText.text = formattedMap;
        }
        else
        {
            Debug.LogWarning("TextMeshPro 对象未分配，请在 Inspector 面板中分配。");
        }
    }


}
