using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class TestUniRxThrottle : MonoBehaviour
{
    Subject<string> attackSubject = new Subject<string>();

    // Start is called before the first frame update
    void Start()
    {
        attackSubject
            .ThrottleFirst(TimeSpan.FromSeconds(2))
            .Subscribe(text => Debug.Log("イベント発生:" + text));
    }

    // Update is called once per frame
    void Update()
    {
        attackSubject.OnNext("攻撃をうけた");

    }
}
