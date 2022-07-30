using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="IntSO",menuName ="IntSO")]
public class IntSO : ScriptableObject
{
    public int Value;
    public void Set(string val)
    {
        if(val!="")
        Value = int.Parse(val);
    }
}
