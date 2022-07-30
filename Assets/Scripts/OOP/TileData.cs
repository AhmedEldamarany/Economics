using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileData :Data
{
    string Name;
  
   public List<Building> Buildings= new List<Building>();
   public List<CityData> Cities= new List<CityData>();

    public void AddCity(CityData cityData)
    {
        calculator.AddCityToTile(cityData, this);
        Cities.Add(cityData);
    }
    public void AddBilding(Building building)
    {
        calculator.AddBuildingToTile(building, this);
        Buildings.Add(building);
    }
}
