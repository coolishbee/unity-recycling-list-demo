using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestChildItem : RecyclingListViewItem {
    public Text leftText;
    public Text rightText1;
    public Text rightText2;

    public Button confirmBtn;

    private TestChildData childData;
    public TestChildData ChildData {
        get { return childData; }
        set {
            childData = value;
            leftText.text = childData.Title;
            rightText1.text = childData.Note1;
            rightText2.text = childData.Note2;
        }
    }

    private void Awake()
    {
        EventListener();
    }

    void EventListener()
    {
        confirmBtn.onClick.AddListener(OnConfirmBtn);
    }

    void OnConfirmBtn()
    {
        Debug.Log("확인하다");
    }
}
