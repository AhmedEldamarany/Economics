using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="BuildingListSO",fileName ="BuildingListSO")]

public class BuildingListSO : ScriptableObject
{
  public   List<Building> BuildingList= new List<Building>();

    public void AddBuilding(Building building)
    {
        BuildingList.Add(building);
        //todo cache the data into json files
    }
}
