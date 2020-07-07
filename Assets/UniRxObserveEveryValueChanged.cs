using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using UniRx.Triggers;
public class UniRxObserveEveryValueChanged : MonoBehaviour
{
    [SerializeField]
    private Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        uiText.ObserveEveryValueChanged(_ => _.text)
            .Subscribe(text=> Debug.Log("テキストの内容:" + text));


        uiText.text = "Test1";
        uiText.text = "Test2";
        uiText.text = "Test3";
        uiText.text = "Test4";

        StartCoroutine(Test());
   }

    IEnumerator Test()
    {
        yield return null;
        uiText.text = "CorTest1";
        yield return null;
        uiText.text = "CorTest2";
        yield return null;
        uiText.text = "CorTest3";
        yield return null;
        uiText.text = "CorTest4";
    }


}
