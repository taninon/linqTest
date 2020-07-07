using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class TestUniRxWhenAll : MonoBehaviour
{
    void Start()
    {
        var testA = Observable.FromCoroutine(TestA);
        var testB = Observable.FromCoroutine(TestB);

        Observable.WhenAll(testA, testB).Subscribe(_ => {
            Debug.Log("All done");
        }).AddTo(this);
    }

    IEnumerator TestA()
    {
        Debug.Log("TestA Start");
        yield return new WaitForSeconds(1);
        Debug.Log("TestA Done");
    }

    IEnumerator TestB()
    {
        Debug.Log("TestB Start");
        yield return new WaitForSeconds(3);
        Debug.Log("TestB Done");
    }
}
