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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
