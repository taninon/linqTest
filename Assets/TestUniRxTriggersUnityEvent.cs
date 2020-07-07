using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class TestUniRxTriggersUnityEvent : MonoBehaviour
{
    [SerializeField] Button uiButton;

    private int count;
    
    // Start is called before the first frame update
    void Start()
    {
        uiButton.OnClickAsObservable()
            .ThrottleFirst(TimeSpan.FromSeconds(0.2f))
            .Subscribe(_=> OnButtonClick());
    }

    void OnButtonClick()
    {
        count++;
        Debug.Log("ボタンが反応した回数"+ count);
    }
}
