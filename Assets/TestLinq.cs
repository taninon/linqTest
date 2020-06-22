using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TestLinq : MonoBehaviour
{
    [SerializeField] CharacterMaster data;

    // Start is called before the first frame update
    void Start()
    {
        var SR = data.sheet
            .OrderBy(r => r.Hp);

        foreach (var c in SR) {
            Debug.Log(c.Name + c.Hp);
        }

        var list = new List<int> { 1, 84, 95, 95, 40, 6 };
        foreach (var x in list.Distinct()) {
            Debug.Log(x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
