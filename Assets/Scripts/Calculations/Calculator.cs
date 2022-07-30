using UnityEngine;

public class Calculator 
{
    //BIG TODO Make a class data and let tiledta, citydata, and building inherit from and have all the num values in it
    public void AddCityToTile(CityData c, TileData d)
    {
        d.Citizens += c.Citizens;
        d.Workers += c.Workers;
        d.Domestics += c.Domestics;
        d.Serfs += c.Serfs;
        d.Slaves += c.Slaves;
    }
    public void AddBuildingToTile(Building b, TileData d)
    {
        d.Citizens += b.Citizens;
        d.Workers += b.Workers;
        d.Domestics += b.Domestics;
        d.Serfs += b.Serfs;
        d.Slaves += b.Slaves;
    }
    public void AddBuildingToCity(Building b, CityData c) // city is passed by reference
    {
        c.Citizens += b.Citizens;
        c.Workers += b.Workers;
        c.Domestics += b.Domestics;
        c.Serfs += b.Serfs;
        c.Slaves += b.Slaves;
    }
    /// <summary>
    /// new
    /// </summary>
   
  
    

    public void CalculateTotalPeople(CityData city) //don't need that anymore
    {
        Debug.Log(city.Buildings.Count);
        foreach (Building b in city.Buildings)
        {
        Debug.Log(city.Citizens);
            if (!b.isCalculated)
            {
                city.Citizens += b.Citizens;
                city.Workers += b.Workers;
                city.Domestics += b.Domestics;
                city.Serfs += b.Serfs;
                city.Slaves += b.Slaves;
                //b.isCalculated = true;
            }
        Debug.Log(city.Citizens);
        }
    }
    public CityData CalcualteAllCities(CityData[] Cities)
    {
        CityData Civilization = new CityData(); //todo needs to be Civilization Object
        foreach (CityData b in Cities)
        {
            Civilization.Citizens += b.Citizens;
            Civilization.Workers += b.Workers;
            Civilization.Domestics += b.Domestics;
            Civilization.Serfs += b.Serfs;
            Civilization.Slaves += b.Slaves;
        }
        return Civilization;
    }
}
