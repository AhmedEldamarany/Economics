using System.Collections.Generic;
using System;
[Serializable]
public class CityData :Data
{
    public string Name; //set and get
    
    public List<Building> Buildings;

    public CityData(string name)
    {
        this.Name = name;
        Buildings = new List<Building>();

    }
    public CityData() 
    {
        Buildings = new List<Building>();
    }

    public CityData(List<Building> buildings)
    {
        Buildings = buildings;
    }

    public CityData(int citizens, int workers, int domestics, int serfs, int slaves) : base(citizens, workers, domestics, serfs, slaves)
    {
        Buildings = new List<Building>();
    }

    public void AddBuilding(Building building)
    {
        calculator.AddBuildingToCity(building, this);
        Buildings.Add(building);
        
    }
    public CityData Multiply(int multiple)
    {
        return new CityData(multiple * Citizens, multiple * Workers, multiple * Domestics, multiple * Serfs, multiple * Slaves);
    }
}
