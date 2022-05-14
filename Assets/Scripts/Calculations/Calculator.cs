using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public void CalculateTotalPeople(City city) //pass by reference?
    {
        foreach (Building b in city.Buildings)
        {
            if (!b.isCalculated)
            {
                city.Citizens += b.Citizens;
                city.Workers += b.Workers;
                city.Domestics += b.Domestics;
                city.Sertfs += b.Sertfs;
                city.Slaves += b.Slaves;
                b.isCalculated = true;
            }
        }
    }
}
