using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
  public string Name; //set and get
  public int Citizens;
  public int Workers;
  public int Domestics;
  public int Sertfs;
  public int Slaves;
    public List<Building> Buildings;
    public City()
    {
        Buildings = new List<Building>();
    }

    public City(List<Building> buildings)
    {
        Buildings = buildings;
    }
    public void AddBuilding(Building building)
    {
        Buildings.Add(building);
       
    }
}
