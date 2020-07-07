using UnityEngine;
using UniRx;
using System;
using UnityEngine.UI;
using UniRx.Triggers;

public class TestUniRxWhenAll2 : MonoBehaviour
{
    private void Start()
    {
        var testA = Observable.Timer(TimeSpan.FromSeconds(1.0f)).Do(_ => Debug.Log("TestA Do"));
        var testB = Observable.Timer(TimeSpan.FromSeconds(2.0f)).Do(_ => Debug.Log("TestB Do"));

        Observable.WhenAll(testA, testB).Subscribe(_ =>
        {
            Debug.Log("All done");
        }).AddTo(this);
    }
}
