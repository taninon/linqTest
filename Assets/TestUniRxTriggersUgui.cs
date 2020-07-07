using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;

public class TestUniRxTriggersUgui : MonoBehaviour
{
    [SerializeField] Text uguiText;

    void Start()
    {
        uguiText.OnPointerClickAsObservable()
            .Subscribe(_ => uguiText.text = "クリックされたよ");
    }

}
