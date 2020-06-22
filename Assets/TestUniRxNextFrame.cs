using UnityEngine;
using UniRx;

public class TestUniRxNextFrame : MonoBehaviour
{

    // Start is called before the first frame update
    private void Start()
    {
        Observable.NextFrame().Subscribe(_ =>
        {
            Debug.Log("1フレーム後に実行");
        }).AddTo(this);

        Debug.Log("すぐ実行");
    }

}
