using UnityEngine;
using System.Collections.Generic;

// ScriptableObject 만드는 방법.

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "ddd",  order = int.MaxValue )]
[System.Serializable]
public class TestScriptAble : ScriptableObject
{
    public int id;
    public string strName;
    public List<string> strDescript;
    public bool IsDelicious;
}
