using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "CityListSO", fileName = "CityListSO")]

public class CityListSO : ScriptableObject
{
    public List<CityData> Cities = new List<CityData>();
}
