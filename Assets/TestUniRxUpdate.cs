using UniRx.Triggers;
using UniRx;
using UnityEngine;

public class TestUniRxUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        this.UpdateAsObservable()
        .Subscribe(x => Move(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))));

        this.UpdateAsObservable()
        .Where(_ => Input.GetKeyDown(KeyCode.Space))
        .Subscribe(_ => Jump());

    }

    private void Move(Vector3 set)
    {

    }

    private void Jump()
    {

    }


}
