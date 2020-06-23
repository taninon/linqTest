using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class TestUniRxSubject : MonoBehaviour
{
    Subject<string> attackSubject = new Subject<string>();

    // Start is called before the first frame update
    void Start()
    {
        attackSubject.Subscribe(text => Debug.Log("イベント発生:" + text));

        attackSubject.OnNext("攻撃をうけた");
        attackSubject.OnNext("呪文をうけた");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
